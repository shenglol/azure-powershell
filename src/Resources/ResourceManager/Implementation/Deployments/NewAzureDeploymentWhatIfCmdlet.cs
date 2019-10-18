// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation
{
    using System;
    using System.Management.Automation;
    using Common.ArgumentCompleters;
    using Management.ResourceManager.Models;
    using Newtonsoft.Json;
    using SdkModels.Deployments;
    using System.Globalization;
    using WindowsAzure.Commands.Utilities.Common;
    using Properties;
    using Rest.Azure;
    using System.Collections.Generic;

    /// <summary>
    /// Creates a new deployment what-if.
    /// </summary>
    [Cmdlet(VerbsCommon.New,
         ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DeploymentWhatIf",
         DefaultParameterSetName = SubscriptionParameterSetWithParameterlessTemplateFile),
     OutputType(typeof(PSWhatIfOperationResult))]
    public class NewAzureDeploymentWhatIfCmdlet : DeploymentWhatIfCmdletWithParameters, IDynamicParameters
    {
        [Parameter(Mandatory = true, HelpMessage = "The deployment scope type.")]
        public DeploymentWhatIfScopeType ScopeType { get; set; }

        [Alias("DeploymentName")]
        [Parameter(Mandatory = false,
            HelpMessage = "The name of the deployment it's going to create. Only valid when a template is used. When a template is used, if the user doesn't specify a deployment name, use the current time, like \"20131223140835\".")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [Parameter(ParameterSetName = SubscriptionParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The location to store deployment data.")]
        [LocationCompleter("Microsoft.Resources/resourceGroups")]
        [ValidateNotNullOrEmpty]
        public string Location { get; set; }

        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateObjectParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateObjectParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateFileParameterObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithTemplateFileParameterFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithParameterlessTemplateObject,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [Parameter(ParameterSetName = ResourceGroupParameterSetWithParameterlessTemplateFile,
            Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The deployment mode.")]
        public DeploymentMode Mode { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The result format.")]
        public WhatIfResultFormat ResultFormat { get; set; } = WhatIfResultFormat.FullResourcePayloads;

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            const string statusMessage = "Getting the latest status of all resources...";
            var clearMessage = new string(' ', statusMessage.Length);
            var information = new HostInformationMessage { Message = statusMessage, NoNewLine = true };
            var clearInformation = new HostInformationMessage { Message = $"\r{clearMessage}\r", NoNewLine = true };
            var tags = new[] { "PSHOST" };

            try
            {
                var parameters = new PSDeploymentWhatIfCmdletParameters
                {
                    DeploymentName = this.Name,
                    Location = this.Location,
                    ScopeType = this.ScopeType,
                    Mode = this.Mode,
                    ResourceGroupName = this.ResourceGroupName,
                    TemplateUri = Uri.IsWellFormedUriString(this.TemplateFile, UriKind.Absolute)
                        ? this.TemplateFile
                        : this.TryResolvePath(this.TemplateFile),
                    TemplateParametersUri = this.TemplateParameterFile,
                    TemplateObject = this.TemplateObject,
                    TemplateParametersObject = this.GetTemplateParameterObject(this.TemplateParameterObject),
                    ResultFormat = this.ResultFormat
                };

                parameters.Validate();

                // Write status.
                this.WriteInformation(information, tags);

                PSWhatIfOperationResult result = ResourceManagerSdkClient.ExecuteDeploymentWhatIf(parameters);

                // Clear status before writing result.
                this.WriteInformation(clearInformation, tags);

                this.WriteObject(result);
            }
            catch (CloudException ce)
            {
                // Clear status before handling exception.
                this.WriteInformation(clearInformation, tags);
                this.HandleException(ce);
            }
            catch (Exception e)
            {
                // Clear status before handling exception.
                this.WriteInformation(clearInformation, tags);
                this.HandleException(e);
            }
        }

        private static string GetRequestId(CloudException ce)
        {
            if (!string.IsNullOrEmpty(ce.RequestId))
            {
                return ce.RequestId;
            }

            if (ce.Response?.Headers != null &&
                ce.Response.Headers.TryGetValue("x-ms-request-id", out IEnumerable<string> requestIdValues))
            {
                return string.Join(";", requestIdValues);
            }

            return string.Empty;
        }

        private void HandleException(CloudException ce)
        {
            var formattedException = new CloudException(string.Format(
                CultureInfo.InvariantCulture,
                Resources.FormattedCloudExceptionMessageTemplate,
                ce.Response?.StatusCode,
                ce.Body?.Code ?? ce.Response?.StatusCode.ToString(),
                ce.Body?.Message ?? ce.Message,
                JsonConvert.SerializeObject(ce.Body?.Details, Formatting.Indented),
                GetRequestId(ce),
                DateTime.UtcNow));

            this.WriteExceptionError(formattedException);
        }

        private void HandleException(Exception e)
        {
            this.WriteExceptionError(e);
        }
    }
}
