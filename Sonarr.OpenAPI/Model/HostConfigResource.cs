/*
 * Sonarr
 *
 * Sonarr API docs - The v3 API docs apply to both v3 and v4 versions of Sonarr. Some functionality may only be available in v4 of the Sonarr application.
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Sonarr.OpenAPI.Client.OpenAPIDateConverter;

namespace Sonarr.OpenAPI.Model
{
    /// <summary>
    /// HostConfigResource
    /// </summary>
    [DataContract(Name = "HostConfigResource")]
    public partial class HostConfigResource : IEquatable<HostConfigResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AuthenticationMethod
        /// </summary>
        [DataMember(Name = "authenticationMethod", EmitDefaultValue = false)]
        public AuthenticationType? AuthenticationMethod { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationRequired
        /// </summary>
        [DataMember(Name = "authenticationRequired", EmitDefaultValue = false)]
        public AuthenticationRequiredType? AuthenticationRequired { get; set; }

        /// <summary>
        /// Gets or Sets UpdateMechanism
        /// </summary>
        [DataMember(Name = "updateMechanism", EmitDefaultValue = false)]
        public UpdateMechanism? UpdateMechanism { get; set; }

        /// <summary>
        /// Gets or Sets ProxyType
        /// </summary>
        [DataMember(Name = "proxyType", EmitDefaultValue = false)]
        public ProxyType? ProxyType { get; set; }

        /// <summary>
        /// Gets or Sets CertificateValidation
        /// </summary>
        [DataMember(Name = "certificateValidation", EmitDefaultValue = false)]
        public CertificateValidationType? CertificateValidation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HostConfigResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="bindAddress">bindAddress.</param>
        /// <param name="port">port.</param>
        /// <param name="sslPort">sslPort.</param>
        /// <param name="enableSsl">enableSsl.</param>
        /// <param name="launchBrowser">launchBrowser.</param>
        /// <param name="authenticationMethod">authenticationMethod.</param>
        /// <param name="authenticationRequired">authenticationRequired.</param>
        /// <param name="analyticsEnabled">analyticsEnabled.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="logLevel">logLevel.</param>
        /// <param name="consoleLogLevel">consoleLogLevel.</param>
        /// <param name="branch">branch.</param>
        /// <param name="apiKey">apiKey.</param>
        /// <param name="sslCertPath">sslCertPath.</param>
        /// <param name="sslCertPassword">sslCertPassword.</param>
        /// <param name="urlBase">urlBase.</param>
        /// <param name="instanceName">instanceName.</param>
        /// <param name="applicationUrl">applicationUrl.</param>
        /// <param name="updateAutomatically">updateAutomatically.</param>
        /// <param name="updateMechanism">updateMechanism.</param>
        /// <param name="updateScriptPath">updateScriptPath.</param>
        /// <param name="proxyEnabled">proxyEnabled.</param>
        /// <param name="proxyType">proxyType.</param>
        /// <param name="proxyHostname">proxyHostname.</param>
        /// <param name="proxyPort">proxyPort.</param>
        /// <param name="proxyUsername">proxyUsername.</param>
        /// <param name="proxyPassword">proxyPassword.</param>
        /// <param name="proxyBypassFilter">proxyBypassFilter.</param>
        /// <param name="proxyBypassLocalAddresses">proxyBypassLocalAddresses.</param>
        /// <param name="certificateValidation">certificateValidation.</param>
        /// <param name="backupFolder">backupFolder.</param>
        /// <param name="backupInterval">backupInterval.</param>
        /// <param name="backupRetention">backupRetention.</param>
        public HostConfigResource(int id = default(int), string bindAddress = default(string), int port = default(int), int sslPort = default(int), bool enableSsl = default(bool), bool launchBrowser = default(bool), AuthenticationType? authenticationMethod = default(AuthenticationType?), AuthenticationRequiredType? authenticationRequired = default(AuthenticationRequiredType?), bool analyticsEnabled = default(bool), string username = default(string), string password = default(string), string logLevel = default(string), string consoleLogLevel = default(string), string branch = default(string), string apiKey = default(string), string sslCertPath = default(string), string sslCertPassword = default(string), string urlBase = default(string), string instanceName = default(string), string applicationUrl = default(string), bool updateAutomatically = default(bool), UpdateMechanism? updateMechanism = default(UpdateMechanism?), string updateScriptPath = default(string), bool proxyEnabled = default(bool), ProxyType? proxyType = default(ProxyType?), string proxyHostname = default(string), int proxyPort = default(int), string proxyUsername = default(string), string proxyPassword = default(string), string proxyBypassFilter = default(string), bool proxyBypassLocalAddresses = default(bool), CertificateValidationType? certificateValidation = default(CertificateValidationType?), string backupFolder = default(string), int backupInterval = default(int), int backupRetention = default(int))
        {
            this.Id = id;
            this.BindAddress = bindAddress;
            this.Port = port;
            this.SslPort = sslPort;
            this.EnableSsl = enableSsl;
            this.LaunchBrowser = launchBrowser;
            this.AuthenticationMethod = authenticationMethod;
            this.AuthenticationRequired = authenticationRequired;
            this.AnalyticsEnabled = analyticsEnabled;
            this.Username = username;
            this.Password = password;
            this.LogLevel = logLevel;
            this.ConsoleLogLevel = consoleLogLevel;
            this.Branch = branch;
            this.ApiKey = apiKey;
            this.SslCertPath = sslCertPath;
            this.SslCertPassword = sslCertPassword;
            this.UrlBase = urlBase;
            this.InstanceName = instanceName;
            this.ApplicationUrl = applicationUrl;
            this.UpdateAutomatically = updateAutomatically;
            this.UpdateMechanism = updateMechanism;
            this.UpdateScriptPath = updateScriptPath;
            this.ProxyEnabled = proxyEnabled;
            this.ProxyType = proxyType;
            this.ProxyHostname = proxyHostname;
            this.ProxyPort = proxyPort;
            this.ProxyUsername = proxyUsername;
            this.ProxyPassword = proxyPassword;
            this.ProxyBypassFilter = proxyBypassFilter;
            this.ProxyBypassLocalAddresses = proxyBypassLocalAddresses;
            this.CertificateValidation = certificateValidation;
            this.BackupFolder = backupFolder;
            this.BackupInterval = backupInterval;
            this.BackupRetention = backupRetention;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets BindAddress
        /// </summary>
        [DataMember(Name = "bindAddress", EmitDefaultValue = true)]
        public string BindAddress { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets SslPort
        /// </summary>
        [DataMember(Name = "sslPort", EmitDefaultValue = false)]
        public int SslPort { get; set; }

        /// <summary>
        /// Gets or Sets EnableSsl
        /// </summary>
        [DataMember(Name = "enableSsl", EmitDefaultValue = true)]
        public bool EnableSsl { get; set; }

        /// <summary>
        /// Gets or Sets LaunchBrowser
        /// </summary>
        [DataMember(Name = "launchBrowser", EmitDefaultValue = true)]
        public bool LaunchBrowser { get; set; }

        /// <summary>
        /// Gets or Sets AnalyticsEnabled
        /// </summary>
        [DataMember(Name = "analyticsEnabled", EmitDefaultValue = true)]
        public bool AnalyticsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets LogLevel
        /// </summary>
        [DataMember(Name = "logLevel", EmitDefaultValue = true)]
        public string LogLevel { get; set; }

        /// <summary>
        /// Gets or Sets ConsoleLogLevel
        /// </summary>
        [DataMember(Name = "consoleLogLevel", EmitDefaultValue = true)]
        public string ConsoleLogLevel { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name = "branch", EmitDefaultValue = true)]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name = "apiKey", EmitDefaultValue = true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets SslCertPath
        /// </summary>
        [DataMember(Name = "sslCertPath", EmitDefaultValue = true)]
        public string SslCertPath { get; set; }

        /// <summary>
        /// Gets or Sets SslCertPassword
        /// </summary>
        [DataMember(Name = "sslCertPassword", EmitDefaultValue = true)]
        public string SslCertPassword { get; set; }

        /// <summary>
        /// Gets or Sets UrlBase
        /// </summary>
        [DataMember(Name = "urlBase", EmitDefaultValue = true)]
        public string UrlBase { get; set; }

        /// <summary>
        /// Gets or Sets InstanceName
        /// </summary>
        [DataMember(Name = "instanceName", EmitDefaultValue = true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationUrl
        /// </summary>
        [DataMember(Name = "applicationUrl", EmitDefaultValue = true)]
        public string ApplicationUrl { get; set; }

        /// <summary>
        /// Gets or Sets UpdateAutomatically
        /// </summary>
        [DataMember(Name = "updateAutomatically", EmitDefaultValue = true)]
        public bool UpdateAutomatically { get; set; }

        /// <summary>
        /// Gets or Sets UpdateScriptPath
        /// </summary>
        [DataMember(Name = "updateScriptPath", EmitDefaultValue = true)]
        public string UpdateScriptPath { get; set; }

        /// <summary>
        /// Gets or Sets ProxyEnabled
        /// </summary>
        [DataMember(Name = "proxyEnabled", EmitDefaultValue = true)]
        public bool ProxyEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ProxyHostname
        /// </summary>
        [DataMember(Name = "proxyHostname", EmitDefaultValue = true)]
        public string ProxyHostname { get; set; }

        /// <summary>
        /// Gets or Sets ProxyPort
        /// </summary>
        [DataMember(Name = "proxyPort", EmitDefaultValue = false)]
        public int ProxyPort { get; set; }

        /// <summary>
        /// Gets or Sets ProxyUsername
        /// </summary>
        [DataMember(Name = "proxyUsername", EmitDefaultValue = true)]
        public string ProxyUsername { get; set; }

        /// <summary>
        /// Gets or Sets ProxyPassword
        /// </summary>
        [DataMember(Name = "proxyPassword", EmitDefaultValue = true)]
        public string ProxyPassword { get; set; }

        /// <summary>
        /// Gets or Sets ProxyBypassFilter
        /// </summary>
        [DataMember(Name = "proxyBypassFilter", EmitDefaultValue = true)]
        public string ProxyBypassFilter { get; set; }

        /// <summary>
        /// Gets or Sets ProxyBypassLocalAddresses
        /// </summary>
        [DataMember(Name = "proxyBypassLocalAddresses", EmitDefaultValue = true)]
        public bool ProxyBypassLocalAddresses { get; set; }

        /// <summary>
        /// Gets or Sets BackupFolder
        /// </summary>
        [DataMember(Name = "backupFolder", EmitDefaultValue = true)]
        public string BackupFolder { get; set; }

        /// <summary>
        /// Gets or Sets BackupInterval
        /// </summary>
        [DataMember(Name = "backupInterval", EmitDefaultValue = false)]
        public int BackupInterval { get; set; }

        /// <summary>
        /// Gets or Sets BackupRetention
        /// </summary>
        [DataMember(Name = "backupRetention", EmitDefaultValue = false)]
        public int BackupRetention { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostConfigResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BindAddress: ").Append(BindAddress).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  SslPort: ").Append(SslPort).Append("\n");
            sb.Append("  EnableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  LaunchBrowser: ").Append(LaunchBrowser).Append("\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
            sb.Append("  AuthenticationRequired: ").Append(AuthenticationRequired).Append("\n");
            sb.Append("  AnalyticsEnabled: ").Append(AnalyticsEnabled).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  LogLevel: ").Append(LogLevel).Append("\n");
            sb.Append("  ConsoleLogLevel: ").Append(ConsoleLogLevel).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  SslCertPath: ").Append(SslCertPath).Append("\n");
            sb.Append("  SslCertPassword: ").Append(SslCertPassword).Append("\n");
            sb.Append("  UrlBase: ").Append(UrlBase).Append("\n");
            sb.Append("  InstanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  ApplicationUrl: ").Append(ApplicationUrl).Append("\n");
            sb.Append("  UpdateAutomatically: ").Append(UpdateAutomatically).Append("\n");
            sb.Append("  UpdateMechanism: ").Append(UpdateMechanism).Append("\n");
            sb.Append("  UpdateScriptPath: ").Append(UpdateScriptPath).Append("\n");
            sb.Append("  ProxyEnabled: ").Append(ProxyEnabled).Append("\n");
            sb.Append("  ProxyType: ").Append(ProxyType).Append("\n");
            sb.Append("  ProxyHostname: ").Append(ProxyHostname).Append("\n");
            sb.Append("  ProxyPort: ").Append(ProxyPort).Append("\n");
            sb.Append("  ProxyUsername: ").Append(ProxyUsername).Append("\n");
            sb.Append("  ProxyPassword: ").Append(ProxyPassword).Append("\n");
            sb.Append("  ProxyBypassFilter: ").Append(ProxyBypassFilter).Append("\n");
            sb.Append("  ProxyBypassLocalAddresses: ").Append(ProxyBypassLocalAddresses).Append("\n");
            sb.Append("  CertificateValidation: ").Append(CertificateValidation).Append("\n");
            sb.Append("  BackupFolder: ").Append(BackupFolder).Append("\n");
            sb.Append("  BackupInterval: ").Append(BackupInterval).Append("\n");
            sb.Append("  BackupRetention: ").Append(BackupRetention).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostConfigResource);
        }

        /// <summary>
        /// Returns true if HostConfigResource instances are equal
        /// </summary>
        /// <param name="input">Instance of HostConfigResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostConfigResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.BindAddress == input.BindAddress ||
                    (this.BindAddress != null &&
                    this.BindAddress.Equals(input.BindAddress))
                ) && 
                (
                    this.Port == input.Port ||
                    this.Port.Equals(input.Port)
                ) && 
                (
                    this.SslPort == input.SslPort ||
                    this.SslPort.Equals(input.SslPort)
                ) && 
                (
                    this.EnableSsl == input.EnableSsl ||
                    this.EnableSsl.Equals(input.EnableSsl)
                ) && 
                (
                    this.LaunchBrowser == input.LaunchBrowser ||
                    this.LaunchBrowser.Equals(input.LaunchBrowser)
                ) && 
                (
                    this.AuthenticationMethod == input.AuthenticationMethod ||
                    this.AuthenticationMethod.Equals(input.AuthenticationMethod)
                ) && 
                (
                    this.AuthenticationRequired == input.AuthenticationRequired ||
                    this.AuthenticationRequired.Equals(input.AuthenticationRequired)
                ) && 
                (
                    this.AnalyticsEnabled == input.AnalyticsEnabled ||
                    this.AnalyticsEnabled.Equals(input.AnalyticsEnabled)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.LogLevel == input.LogLevel ||
                    (this.LogLevel != null &&
                    this.LogLevel.Equals(input.LogLevel))
                ) && 
                (
                    this.ConsoleLogLevel == input.ConsoleLogLevel ||
                    (this.ConsoleLogLevel != null &&
                    this.ConsoleLogLevel.Equals(input.ConsoleLogLevel))
                ) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.SslCertPath == input.SslCertPath ||
                    (this.SslCertPath != null &&
                    this.SslCertPath.Equals(input.SslCertPath))
                ) && 
                (
                    this.SslCertPassword == input.SslCertPassword ||
                    (this.SslCertPassword != null &&
                    this.SslCertPassword.Equals(input.SslCertPassword))
                ) && 
                (
                    this.UrlBase == input.UrlBase ||
                    (this.UrlBase != null &&
                    this.UrlBase.Equals(input.UrlBase))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.ApplicationUrl == input.ApplicationUrl ||
                    (this.ApplicationUrl != null &&
                    this.ApplicationUrl.Equals(input.ApplicationUrl))
                ) && 
                (
                    this.UpdateAutomatically == input.UpdateAutomatically ||
                    this.UpdateAutomatically.Equals(input.UpdateAutomatically)
                ) && 
                (
                    this.UpdateMechanism == input.UpdateMechanism ||
                    this.UpdateMechanism.Equals(input.UpdateMechanism)
                ) && 
                (
                    this.UpdateScriptPath == input.UpdateScriptPath ||
                    (this.UpdateScriptPath != null &&
                    this.UpdateScriptPath.Equals(input.UpdateScriptPath))
                ) && 
                (
                    this.ProxyEnabled == input.ProxyEnabled ||
                    this.ProxyEnabled.Equals(input.ProxyEnabled)
                ) && 
                (
                    this.ProxyType == input.ProxyType ||
                    this.ProxyType.Equals(input.ProxyType)
                ) && 
                (
                    this.ProxyHostname == input.ProxyHostname ||
                    (this.ProxyHostname != null &&
                    this.ProxyHostname.Equals(input.ProxyHostname))
                ) && 
                (
                    this.ProxyPort == input.ProxyPort ||
                    this.ProxyPort.Equals(input.ProxyPort)
                ) && 
                (
                    this.ProxyUsername == input.ProxyUsername ||
                    (this.ProxyUsername != null &&
                    this.ProxyUsername.Equals(input.ProxyUsername))
                ) && 
                (
                    this.ProxyPassword == input.ProxyPassword ||
                    (this.ProxyPassword != null &&
                    this.ProxyPassword.Equals(input.ProxyPassword))
                ) && 
                (
                    this.ProxyBypassFilter == input.ProxyBypassFilter ||
                    (this.ProxyBypassFilter != null &&
                    this.ProxyBypassFilter.Equals(input.ProxyBypassFilter))
                ) && 
                (
                    this.ProxyBypassLocalAddresses == input.ProxyBypassLocalAddresses ||
                    this.ProxyBypassLocalAddresses.Equals(input.ProxyBypassLocalAddresses)
                ) && 
                (
                    this.CertificateValidation == input.CertificateValidation ||
                    this.CertificateValidation.Equals(input.CertificateValidation)
                ) && 
                (
                    this.BackupFolder == input.BackupFolder ||
                    (this.BackupFolder != null &&
                    this.BackupFolder.Equals(input.BackupFolder))
                ) && 
                (
                    this.BackupInterval == input.BackupInterval ||
                    this.BackupInterval.Equals(input.BackupInterval)
                ) && 
                (
                    this.BackupRetention == input.BackupRetention ||
                    this.BackupRetention.Equals(input.BackupRetention)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BindAddress != null)
                    hashCode = hashCode * 59 + this.BindAddress.GetHashCode();
                hashCode = hashCode * 59 + this.Port.GetHashCode();
                hashCode = hashCode * 59 + this.SslPort.GetHashCode();
                hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                hashCode = hashCode * 59 + this.LaunchBrowser.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticationMethod.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticationRequired.GetHashCode();
                hashCode = hashCode * 59 + this.AnalyticsEnabled.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.LogLevel != null)
                    hashCode = hashCode * 59 + this.LogLevel.GetHashCode();
                if (this.ConsoleLogLevel != null)
                    hashCode = hashCode * 59 + this.ConsoleLogLevel.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.SslCertPath != null)
                    hashCode = hashCode * 59 + this.SslCertPath.GetHashCode();
                if (this.SslCertPassword != null)
                    hashCode = hashCode * 59 + this.SslCertPassword.GetHashCode();
                if (this.UrlBase != null)
                    hashCode = hashCode * 59 + this.UrlBase.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.ApplicationUrl != null)
                    hashCode = hashCode * 59 + this.ApplicationUrl.GetHashCode();
                hashCode = hashCode * 59 + this.UpdateAutomatically.GetHashCode();
                hashCode = hashCode * 59 + this.UpdateMechanism.GetHashCode();
                if (this.UpdateScriptPath != null)
                    hashCode = hashCode * 59 + this.UpdateScriptPath.GetHashCode();
                hashCode = hashCode * 59 + this.ProxyEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.ProxyType.GetHashCode();
                if (this.ProxyHostname != null)
                    hashCode = hashCode * 59 + this.ProxyHostname.GetHashCode();
                hashCode = hashCode * 59 + this.ProxyPort.GetHashCode();
                if (this.ProxyUsername != null)
                    hashCode = hashCode * 59 + this.ProxyUsername.GetHashCode();
                if (this.ProxyPassword != null)
                    hashCode = hashCode * 59 + this.ProxyPassword.GetHashCode();
                if (this.ProxyBypassFilter != null)
                    hashCode = hashCode * 59 + this.ProxyBypassFilter.GetHashCode();
                hashCode = hashCode * 59 + this.ProxyBypassLocalAddresses.GetHashCode();
                hashCode = hashCode * 59 + this.CertificateValidation.GetHashCode();
                if (this.BackupFolder != null)
                    hashCode = hashCode * 59 + this.BackupFolder.GetHashCode();
                hashCode = hashCode * 59 + this.BackupInterval.GetHashCode();
                hashCode = hashCode * 59 + this.BackupRetention.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
