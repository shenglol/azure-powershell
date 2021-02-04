﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Aks.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Aks.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please add {0} to your search PATH so the {1} can be found..
        /// </summary>
        internal static string AddDirectoryToPath {
            get {
                return ResourceManager.GetString("AddDirectoryToPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add-on {0} is not installed for this cluster..
        /// </summary>
        internal static string AddonIsNotInstalled {
            get {
                return ResourceManager.GetString("AddonIsNotInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WorkspaceResourceId must not be null when enabling add-on Monitoring..
        /// </summary>
        internal static string AddonMonitoringShouldWorkWithWorkspaceResourceId {
            get {
                return ResourceManager.GetString("AddonMonitoringShouldWorkWithWorkspaceResourceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add-on {0} is not defined. The accepted add-on names are {1}..
        /// </summary>
        internal static string AddonNotDefined {
            get {
                return ResourceManager.GetString("AddonNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SubnetName must not be null when enabling add-on VirtualNode..
        /// </summary>
        internal static string AddonVirtualNodeShouldWorkWithSubnetName {
            get {
                return ResourceManager.GetString("AddonVirtualNodeShouldWorkWithSubnetName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Role Assignment.
        /// </summary>
        internal static string AddRoleAssignment {
            get {
                return ResourceManager.GetString("AddRoleAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Node pool already exists, confirm action..
        /// </summary>
        internal static string AgentPoolAlreadyExistsConfirmAction {
            get {
                return ResourceManager.GetString("AgentPoolAlreadyExistsConfirmAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The node pool already exists. Please use Update-AzAksNodePool for update..
        /// </summary>
        internal static string AgentPoolAlreadyExistsError {
            get {
                return ResourceManager.GetString("AgentPoolAlreadyExistsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Node pool doesn&apos;t exist..
        /// </summary>
        internal static string AgentPoolDoesNotExist {
            get {
                return ResourceManager.GetString("AgentPoolDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Node pool exists: {0}..
        /// </summary>
        internal static string AgentPoolExists {
            get {
                return ResourceManager.GetString("AgentPoolExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Node pool is new..
        /// </summary>
        internal static string AgentPoolIsNew {
            get {
                return ResourceManager.GetString("AgentPoolIsNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following three paramters must appear together if one of them appears: NodeMinCount, NodeMaxCount and EnableNodeAutoScaling..
        /// </summary>
        internal static string AksNodePoolAutoScalingParametersMustAppearTogether {
            get {
                return ResourceManager.GetString("AksNodePoolAutoScalingParametersMustAppearTogether", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cluster already exists, confirm action..
        /// </summary>
        internal static string ClusterAlreadyExistsConfirmAction {
            get {
                return ResourceManager.GetString("ClusterAlreadyExistsConfirmAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cluster does not exist..
        /// </summary>
        internal static string ClusterDoesNotExist {
            get {
                return ResourceManager.GetString("ClusterDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cluster exists: {0}.
        /// </summary>
        internal static string ClusterExists {
            get {
                return ResourceManager.GetString("ClusterExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cluster is new..
        /// </summary>
        internal static string ClusterIsNew {
            get {
                return ResourceManager.GetString("ClusterIsNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not add &apos;acrpull&apos; role assignment, please make sure you have right permission..
        /// </summary>
        internal static string CouldNotAddAcrRoleAssignment {
            get {
                return ResourceManager.GetString("CouldNotAddAcrRoleAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not assign subscription contributor permission to service principal just created. Please make sure you have permission to assign subscription contributor role, or you could use parameter -ClientIdAndSecret to specify one existing service principal id and secret..
        /// </summary>
        internal static string CouldNotAssignServicePrincipalWithSubsContributorPermission {
            get {
                return ResourceManager.GetString("CouldNotAssignServicePrincipalWithSubsContributorPermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not create a service principal. Do you have enough permission to create service principal? Or you could use parameter -ClientIdAndSecret to specify one existing service principal id and secret..
        /// </summary>
        internal static string CouldNotCreateAServicePrincipalWithTheRightPermissionsAreYouAnOwner {
            get {
                return ResourceManager.GetString("CouldNotCreateAServicePrincipalWithTheRightPermissionsAreYouAnOwner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find object id of service principal : {0}, please make sure you have graph directory.read permission which is required for grant acrpull permission..
        /// </summary>
        internal static string CouldNotFindObjectIdForServicePrincipal {
            get {
                return ResourceManager.GetString("CouldNotFindObjectIdForServicePrincipal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find specified Acr &apos;{0}&apos; to attach..
        /// </summary>
        internal static string CouldNotFindSpecifiedAcr {
            get {
                return ResourceManager.GetString("CouldNotFindSpecifiedAcr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find SSH public key in default path &apos;{0}&apos; which is required for creating k8s cluster. See https://docs.microsoft.com/en-us/azure/virtual-machines/linux/mac-create-ssh-keys or https://docs.microsoft.com/en-us/azure/virtual-machines/linux/ssh-from-windows for generating a key pair manually; or you could try to add switch parameter -GenerateSshKey during calling New-AzAksCluster which will automatically generate SSH key file if you have ssh-keygen installed..
        /// </summary>
        internal static string CouldNotFindSshPublicKeyInError {
            get {
                return ResourceManager.GetString("CouldNotFindSshPublicKeyInError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created a new Service Principal and assigned the contributor role for this subscription..
        /// </summary>
        internal static string CreatedANewServicePrincipalAndAssignedTheContributorRole {
            get {
                return ResourceManager.GetString("CreatedANewServicePrincipalAndAssignedTheContributorRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a managed Kubernetes cluster..
        /// </summary>
        internal static string CreatingAManagedKubernetesCluster {
            get {
                return ResourceManager.GetString("CreatingAManagedKubernetesCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new cluster Node pool..
        /// </summary>
        internal static string CreatingClusterAgentPool {
            get {
                return ResourceManager.GetString("CreatingClusterAgentPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default ssh key file {0} already exists. Please use parameter -SshKeyValue &apos;{0}&apos; instead of -GenerateSshKey..
        /// </summary>
        internal static string DefaultSshKeyAlreadyExist {
            get {
                return ResourceManager.GetString("DefaultSshKeyAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deploying your managed Kubernetes cluster..
        /// </summary>
        internal static string DeployingYourManagedKubeCluster {
            get {
                return ResourceManager.GetString("DeployingYourManagedKubeCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did not find job..
        /// </summary>
        internal static string DidNotFindJob {
            get {
                return ResourceManager.GetString("DidNotFindJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don&apos;t use -GenerateSshKey and -SshKeyValue at the same time..
        /// </summary>
        internal static string DonotUseGenerateSshKeyWithSshKeyValue {
            get {
                return ResourceManager.GetString("DonotUseGenerateSshKeyWithSshKeyValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading kubectl from internet.
        /// </summary>
        internal static string DownloadingKubectlFromWeb {
            get {
                return ResourceManager.GetString("DownloadingKubectlFromWeb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to create a new managed Kubernetes cluster?.
        /// </summary>
        internal static string DoYouWantToCreateANewManagedKubernetesCluster {
            get {
                return ResourceManager.GetString("DoYouWantToCreateANewManagedKubernetesCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to craete a new Node pool?.
        /// </summary>
        internal static string DoYouWantToCreateClusterAgentPool {
            get {
                return ResourceManager.GetString("DoYouWantToCreateClusterAgentPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete the Node pool?.
        /// </summary>
        internal static string DoYouWantToDeleteTheAgentPool {
            get {
                return ResourceManager.GetString("DoYouWantToDeleteTheAgentPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete the managed Kubernetes cluster?.
        /// </summary>
        internal static string DoYouWantToDeleteTheManagedKubernetesCluster {
            get {
                return ResourceManager.GetString("DoYouWantToDeleteTheManagedKubernetesCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to import the Kubernetes config?.
        /// </summary>
        internal static string DoYouWantToImportTheKubernetesConfig {
            get {
                return ResourceManager.GetString("DoYouWantToImportTheKubernetesConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to overwrite the existing {0}?.
        /// </summary>
        internal static string DoYouWantToOverwriteExistingFile {
            get {
                return ResourceManager.GetString("DoYouWantToOverwriteExistingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to generate SSH key with detail error: {0}.\nPlease create one issue at https://github.com/Azure/azure-powershell/issues if issue remains..
        /// </summary>
        internal static string FailedToGenerateSshKey {
            get {
                return ResourceManager.GetString("FailedToGenerateSshKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to run &apos;ssh-keygen&apos; to generate SSH key with detail error: {0}. \nPlease make sure &apos;ssh-keygen&apos; is runable from cmd on Windows or shell on Linux/MacOS, usually you just need to install OpenSSH client which contains &apos;ssh-keygen&apos;, then restart PowerShell and try again..
        /// </summary>
        internal static string FailedToRunSshKeyGen {
            get {
                return ResourceManager.GetString("FailedToRunSshKeyGen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching the clusterAdmin kubectl config.
        /// </summary>
        internal static string FetchingTheClusterAdminKubectlConfig {
            get {
                return ResourceManager.GetString("FetchingTheClusterAdminKubectlConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching the default clusterUser kubectl config.
        /// </summary>
        internal static string FetchingTheDefaultClusterUserKubectlConfig {
            get {
                return ResourceManager.GetString("FetchingTheDefaultClusterUserKubectlConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching SSH public key from file {0}.
        /// </summary>
        internal static string FetchSshPublicKeyFromFile {
            get {
                return ResourceManager.GetString("FetchSshPublicKeyFromFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File was not specified. Writing credential to {0}..
        /// </summary>
        internal static string FileWasNotSpecifiedWritingCredentialTo {
            get {
                return ResourceManager.GetString("FileWasNotSpecifiedWritingCredentialTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Importing Kubernetes config resource..
        /// </summary>
        internal static string ImportingKubernetesConfigResource {
            get {
                return ResourceManager.GetString("ImportingKubernetesConfigResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified KubernetesVersion is not supported in this region. Please run &apos;Get-AzAksVersion&apos; to get supported version..
        /// </summary>
        internal static string K8sVersionNotSupported {
            get {
                return ResourceManager.GetString("K8sVersionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to kubectl is required to be installed and on your path to execute this command. Kubectl is available here: https://kubernetes.io/docs/tasks/tools/install-kubectl/..
        /// </summary>
        internal static string KubectlIsRequriedToBeInstalledAndOnYourPathToExecute {
            get {
                return ResourceManager.GetString("KubectlIsRequriedToBeInstalledAndOnYourPathToExecute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AzureRmKubernetesCredential {0} in {1}.
        /// </summary>
        internal static string KubernetesCredentialAction {
            get {
                return ResourceManager.GetString("KubernetesCredentialAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location can&apos;t be updated for existing cluster..
        /// </summary>
        internal static string LocationCannotBeUpdateForExistingCluster {
            get {
                return ResourceManager.GetString("LocationCannotBeUpdateForExistingCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NetworkPlugin must be azure if you want to use Windows..
        /// </summary>
        internal static string NetworkPluginShouldBeAzure {
            get {
                return ResourceManager.GetString("NetworkPluginShouldBeAzure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No config file located at {0}. Creating Kube config..
        /// </summary>
        internal static string NoConfigFileLocatedAtCreatingKubeConfig {
            get {
                return ResourceManager.GetString("NoConfigFileLocatedAtCreatingKubeConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following three paramters must appear together if one of them appears: MinCount, MaxCount and EnableAutoScaling..
        /// </summary>
        internal static string NodePoolAutoScalingParametersMustAppearTogether {
            get {
                return ResourceManager.GetString("NodePoolAutoScalingParametersMustAppearTogether", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There&apos;s no kubectl available in the mirror site for OSX..
        /// </summary>
        internal static string NoKubectlForOsxOnMirror {
            get {
                return ResourceManager.GetString("NoKubectlForOsxOnMirror", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Service Principal found in {0} for current subscription {1}. Trying to create a new Service Principal with Contributor role for the subscription..
        /// </summary>
        internal static string NoServicePrincipalFoundCreatingANewServicePrincipal {
            get {
                return ResourceManager.GetString("NoServicePrincipalFoundCreatingANewServicePrincipal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, this cmdlet is not supported in current OS..
        /// </summary>
        internal static string NotSupportOnThisOs {
            get {
                return ResourceManager.GetString("NotSupportOnThisOs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter set could not be determined from the provided parameters. Please check the documentation for appropriate parameters, and report this issue at https://github.com/azure/azure-powershell/issues.
        /// </summary>
        internal static string ParameterSetError {
            get {
                return ResourceManager.GetString("ParameterSetError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parent source must not be null or empty..
        /// </summary>
        internal static string ParentResourceMustNotBeEmpty {
            get {
                return ResourceManager.GetString("ParentResourceMustNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to pid doesn&apos;t exist or job is already dead.
        /// </summary>
        internal static string PidDoesntExistOrJobIsAlreadyDead {
            get {
                return ResourceManager.GetString("PidDoesntExistOrJobIsAlreadyDead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preparing for deployment of your managed Kubernetes cluster..
        /// </summary>
        internal static string PreparingForDeploymentOfYourManagedKubernetesCluster {
            get {
                return ResourceManager.GetString("PreparingForDeploymentOfYourManagedKubernetesCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preparing for deployment of your new managed Kubernetes cluster..
        /// </summary>
        internal static string PreparingForDeploymentOfYourNewManagedKubernetesCluster {
            get {
                return ResourceManager.GetString("PreparingForDeploymentOfYourNewManagedKubernetesCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process started with id: {0}..
        /// </summary>
        internal static string ProcessStartedWithId {
            get {
                return ResourceManager.GetString("ProcessStartedWithId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the Node pool..
        /// </summary>
        internal static string RemovingTheAgentPool {
            get {
                return ResourceManager.GetString("RemovingTheAgentPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the managed Kubernetes cluster..
        /// </summary>
        internal static string RemovingTheManagedKubernetesCluster {
            get {
                return ResourceManager.GetString("RemovingTheManagedKubernetesCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retry {0} for {1} after error: {2}.
        /// </summary>
        internal static string RetryAfterActionError {
            get {
                return ResourceManager.GetString("RetryAfterActionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running in background job Kubectl-Tunnel: kubectl --kubeconfig {0} --namespace kube-system port-forward {1} 8001:9090.
        /// </summary>
        internal static string RunningInBackgroundJobKubectlTunnel {
            get {
                return ResourceManager.GetString("RunningInBackgroundJobKubectlTunnel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running: kubectl get pods --kubeconfig {0} --namespace kube-system --output name --selector k8s-app=kubernetes-dashboard.
        /// </summary>
        internal static string RunningKubectlGetPodsKubeconfigNamespaceSelector {
            get {
                return ResourceManager.GetString("RunningKubectlGetPodsKubeconfigNamespaceSelector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Plain text of SecureString should match the patten {0}..
        /// </summary>
        internal static string SecureStringNotValid {
            get {
                return ResourceManager.GetString("SecureStringNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service Principal Create.
        /// </summary>
        internal static string ServicePrincipalCreate {
            get {
                return ResourceManager.GetString("ServicePrincipalCreate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting up browser pop..
        /// </summary>
        internal static string SettingUpBrowserPop {
            get {
                return ResourceManager.GetString("SettingUpBrowserPop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify one existing Node pool name to &apos;NodeName&apos; for updating Node pool properties..
        /// </summary>
        internal static string SpecifiedAgentPoolDoesNotExist {
            get {
                return ResourceManager.GetString("SpecifiedAgentPoolDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started: `kubectl {0}`.
        /// </summary>
        internal static string StartedKubectl {
            get {
                return ResourceManager.GetString("StartedKubectl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting browser: {0}.
        /// </summary>
        internal static string StartingBrowser {
            get {
                return ResourceManager.GetString("StartingBrowser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting: `kubectl {0}`.
        /// </summary>
        internal static string StartingKubectl {
            get {
                return ResourceManager.GetString("StartingKubectl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting on default.
        /// </summary>
        internal static string StartingOnDefault {
            get {
                return ResourceManager.GetString("StartingOnDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopped process with id {0}.
        /// </summary>
        internal static string StoppedProcesWithId {
            get {
                return ResourceManager.GetString("StoppedProcesWithId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping existing Kubectl-Tunnel job..
        /// </summary>
        internal static string StoppingExistingKubectlTunnelJob {
            get {
                return ResourceManager.GetString("StoppingExistingKubectlTunnelJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping existing Kubectl-Tunnel job with pid {0}..
        /// </summary>
        internal static string StoppingExistingKubectlTunnelJobWithPid {
            get {
                return ResourceManager.GetString("StoppingExistingKubectlTunnelJobWithPid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping process with id {0}.
        /// </summary>
        internal static string StoppingProcessWithId {
            get {
                return ResourceManager.GetString("StoppingProcessWithId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update the Node pool..
        /// </summary>
        internal static string UpdateAgentPool {
            get {
                return ResourceManager.GetString("UpdateAgentPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update or create a managed Kubernetes cluster..
        /// </summary>
        internal static string UpdateOrCreateAManagedKubernetesCluster {
            get {
                return ResourceManager.GetString("UpdateOrCreateAManagedKubernetesCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating admin username.
        /// </summary>
        internal static string UpdatingAdminUsername {
            get {
                return ResourceManager.GetString("UpdatingAdminUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating DnsNamePrefix.
        /// </summary>
        internal static string UpdatingDnsNamePrefix {
            get {
                return ResourceManager.GetString("UpdatingDnsNamePrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating Kubernetes version.
        /// </summary>
        internal static string UpdatingKubernetesVersion {
            get {
                return ResourceManager.GetString("UpdatingKubernetesVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating node count.
        /// </summary>
        internal static string UpdatingNodeCount {
            get {
                return ResourceManager.GetString("UpdatingNodeCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating node OS disk size.
        /// </summary>
        internal static string UpdatingNodeOsDiskSize {
            get {
                return ResourceManager.GetString("UpdatingNodeOsDiskSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating NodePoolMode..
        /// </summary>
        internal static string UpdatingNodePoolMode {
            get {
                return ResourceManager.GetString("UpdatingNodePoolMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating node VM size.
        /// </summary>
        internal static string UpdatingNodeVmSize {
            get {
                return ResourceManager.GetString("UpdatingNodeVmSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating service principal.
        /// </summary>
        internal static string UpdatingServicePrincipal {
            get {
                return ResourceManager.GetString("UpdatingServicePrincipal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating SshKeyValue.
        /// </summary>
        internal static string UpdatingSshKeyValue {
            get {
                return ResourceManager.GetString("UpdatingSshKeyValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating tags.
        /// </summary>
        internal static string UpdatingTags {
            get {
                return ResourceManager.GetString("UpdatingTags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating your managed Kubernetes cluster..
        /// </summary>
        internal static string UpdatingYourManagedKubernetesCluster {
            get {
                return ResourceManager.GetString("UpdatingYourManagedKubernetesCluster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using Node pool from pipeline..
        /// </summary>
        internal static string UsingAgentPoolFromPipeline {
            get {
                return ResourceManager.GetString("UsingAgentPoolFromPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using cluster from pipeline..
        /// </summary>
        internal static string UsingClusterFromPipeline {
            get {
                return ResourceManager.GetString("UsingClusterFromPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource group location is invalid, using default location {0}..
        /// </summary>
        internal static string UsingDefaultLocation {
            get {
                return ResourceManager.GetString("UsingDefaultLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using DNS name prefix {0}..
        /// </summary>
        internal static string UsingDnsNamePrefix {
            get {
                return ResourceManager.GetString("UsingDnsNamePrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using location {0} from the resource group {1}..
        /// </summary>
        internal static string UsingLocationFromTheResourceGroup {
            get {
                return ResourceManager.GetString("UsingLocationFromTheResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using SSH public key data as command line string..
        /// </summary>
        internal static string UsingSshPublicKeyDataAsCommandLineString {
            get {
                return ResourceManager.GetString("UsingSshPublicKeyDataAsCommandLineString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must set VmSetType as &apos;VirtualMachineScaleSets&apos; for Windows node pool..
        /// </summary>
        internal static string VmSetTypeIsIncorrectForWindowsPool {
            get {
                return ResourceManager.GetString("VmSetTypeIsIncorrectForWindowsPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows agent pool name can not be longer than 6 characters..
        /// </summary>
        internal static string WindowsNodePoolNameLengthLimitation {
            get {
                return ResourceManager.GetString("WindowsNodePoolNameLengthLimitation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WindowsProfileAdminUser and WindowsProfileAdminUserPassword must appear together..
        /// </summary>
        internal static string WindowsUserNameAndPasswordShouldAppearTogether {
            get {
                return ResourceManager.GetString("WindowsUserNameAndPasswordShouldAppearTogether", resourceCulture);
            }
        }
    }
}
