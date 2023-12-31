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
    /// MediaManagementConfigResource
    /// </summary>
    [DataContract(Name = "MediaManagementConfigResource")]
    public partial class MediaManagementConfigResource : IEquatable<MediaManagementConfigResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DownloadPropersAndRepacks
        /// </summary>
        [DataMember(Name = "downloadPropersAndRepacks", EmitDefaultValue = false)]
        public ProperDownloadTypes? DownloadPropersAndRepacks { get; set; }

        /// <summary>
        /// Gets or Sets FileDate
        /// </summary>
        [DataMember(Name = "fileDate", EmitDefaultValue = false)]
        public FileDateType? FileDate { get; set; }

        /// <summary>
        /// Gets or Sets RescanAfterRefresh
        /// </summary>
        [DataMember(Name = "rescanAfterRefresh", EmitDefaultValue = false)]
        public RescanAfterRefreshType? RescanAfterRefresh { get; set; }

        /// <summary>
        /// Gets or Sets EpisodeTitleRequired
        /// </summary>
        [DataMember(Name = "episodeTitleRequired", EmitDefaultValue = false)]
        public EpisodeTitleRequiredType? EpisodeTitleRequired { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaManagementConfigResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="autoUnmonitorPreviouslyDownloadedEpisodes">autoUnmonitorPreviouslyDownloadedEpisodes.</param>
        /// <param name="recycleBin">recycleBin.</param>
        /// <param name="recycleBinCleanupDays">recycleBinCleanupDays.</param>
        /// <param name="downloadPropersAndRepacks">downloadPropersAndRepacks.</param>
        /// <param name="createEmptySeriesFolders">createEmptySeriesFolders.</param>
        /// <param name="deleteEmptyFolders">deleteEmptyFolders.</param>
        /// <param name="fileDate">fileDate.</param>
        /// <param name="rescanAfterRefresh">rescanAfterRefresh.</param>
        /// <param name="setPermissionsLinux">setPermissionsLinux.</param>
        /// <param name="chmodFolder">chmodFolder.</param>
        /// <param name="chownGroup">chownGroup.</param>
        /// <param name="episodeTitleRequired">episodeTitleRequired.</param>
        /// <param name="skipFreeSpaceCheckWhenImporting">skipFreeSpaceCheckWhenImporting.</param>
        /// <param name="minimumFreeSpaceWhenImporting">minimumFreeSpaceWhenImporting.</param>
        /// <param name="copyUsingHardlinks">copyUsingHardlinks.</param>
        /// <param name="useScriptImport">useScriptImport.</param>
        /// <param name="scriptImportPath">scriptImportPath.</param>
        /// <param name="importExtraFiles">importExtraFiles.</param>
        /// <param name="extraFileExtensions">extraFileExtensions.</param>
        /// <param name="enableMediaInfo">enableMediaInfo.</param>
        public MediaManagementConfigResource(int id = default(int), bool autoUnmonitorPreviouslyDownloadedEpisodes = default(bool), string recycleBin = default(string), int recycleBinCleanupDays = default(int), ProperDownloadTypes? downloadPropersAndRepacks = default(ProperDownloadTypes?), bool createEmptySeriesFolders = default(bool), bool deleteEmptyFolders = default(bool), FileDateType? fileDate = default(FileDateType?), RescanAfterRefreshType? rescanAfterRefresh = default(RescanAfterRefreshType?), bool setPermissionsLinux = default(bool), string chmodFolder = default(string), string chownGroup = default(string), EpisodeTitleRequiredType? episodeTitleRequired = default(EpisodeTitleRequiredType?), bool skipFreeSpaceCheckWhenImporting = default(bool), int minimumFreeSpaceWhenImporting = default(int), bool copyUsingHardlinks = default(bool), bool useScriptImport = default(bool), string scriptImportPath = default(string), bool importExtraFiles = default(bool), string extraFileExtensions = default(string), bool enableMediaInfo = default(bool))
        {
            this.Id = id;
            this.AutoUnmonitorPreviouslyDownloadedEpisodes = autoUnmonitorPreviouslyDownloadedEpisodes;
            this.RecycleBin = recycleBin;
            this.RecycleBinCleanupDays = recycleBinCleanupDays;
            this.DownloadPropersAndRepacks = downloadPropersAndRepacks;
            this.CreateEmptySeriesFolders = createEmptySeriesFolders;
            this.DeleteEmptyFolders = deleteEmptyFolders;
            this.FileDate = fileDate;
            this.RescanAfterRefresh = rescanAfterRefresh;
            this.SetPermissionsLinux = setPermissionsLinux;
            this.ChmodFolder = chmodFolder;
            this.ChownGroup = chownGroup;
            this.EpisodeTitleRequired = episodeTitleRequired;
            this.SkipFreeSpaceCheckWhenImporting = skipFreeSpaceCheckWhenImporting;
            this.MinimumFreeSpaceWhenImporting = minimumFreeSpaceWhenImporting;
            this.CopyUsingHardlinks = copyUsingHardlinks;
            this.UseScriptImport = useScriptImport;
            this.ScriptImportPath = scriptImportPath;
            this.ImportExtraFiles = importExtraFiles;
            this.ExtraFileExtensions = extraFileExtensions;
            this.EnableMediaInfo = enableMediaInfo;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets AutoUnmonitorPreviouslyDownloadedEpisodes
        /// </summary>
        [DataMember(Name = "autoUnmonitorPreviouslyDownloadedEpisodes", EmitDefaultValue = true)]
        public bool AutoUnmonitorPreviouslyDownloadedEpisodes { get; set; }

        /// <summary>
        /// Gets or Sets RecycleBin
        /// </summary>
        [DataMember(Name = "recycleBin", EmitDefaultValue = true)]
        public string RecycleBin { get; set; }

        /// <summary>
        /// Gets or Sets RecycleBinCleanupDays
        /// </summary>
        [DataMember(Name = "recycleBinCleanupDays", EmitDefaultValue = false)]
        public int RecycleBinCleanupDays { get; set; }

        /// <summary>
        /// Gets or Sets CreateEmptySeriesFolders
        /// </summary>
        [DataMember(Name = "createEmptySeriesFolders", EmitDefaultValue = true)]
        public bool CreateEmptySeriesFolders { get; set; }

        /// <summary>
        /// Gets or Sets DeleteEmptyFolders
        /// </summary>
        [DataMember(Name = "deleteEmptyFolders", EmitDefaultValue = true)]
        public bool DeleteEmptyFolders { get; set; }

        /// <summary>
        /// Gets or Sets SetPermissionsLinux
        /// </summary>
        [DataMember(Name = "setPermissionsLinux", EmitDefaultValue = true)]
        public bool SetPermissionsLinux { get; set; }

        /// <summary>
        /// Gets or Sets ChmodFolder
        /// </summary>
        [DataMember(Name = "chmodFolder", EmitDefaultValue = true)]
        public string ChmodFolder { get; set; }

        /// <summary>
        /// Gets or Sets ChownGroup
        /// </summary>
        [DataMember(Name = "chownGroup", EmitDefaultValue = true)]
        public string ChownGroup { get; set; }

        /// <summary>
        /// Gets or Sets SkipFreeSpaceCheckWhenImporting
        /// </summary>
        [DataMember(Name = "skipFreeSpaceCheckWhenImporting", EmitDefaultValue = true)]
        public bool SkipFreeSpaceCheckWhenImporting { get; set; }

        /// <summary>
        /// Gets or Sets MinimumFreeSpaceWhenImporting
        /// </summary>
        [DataMember(Name = "minimumFreeSpaceWhenImporting", EmitDefaultValue = false)]
        public int MinimumFreeSpaceWhenImporting { get; set; }

        /// <summary>
        /// Gets or Sets CopyUsingHardlinks
        /// </summary>
        [DataMember(Name = "copyUsingHardlinks", EmitDefaultValue = true)]
        public bool CopyUsingHardlinks { get; set; }

        /// <summary>
        /// Gets or Sets UseScriptImport
        /// </summary>
        [DataMember(Name = "useScriptImport", EmitDefaultValue = true)]
        public bool UseScriptImport { get; set; }

        /// <summary>
        /// Gets or Sets ScriptImportPath
        /// </summary>
        [DataMember(Name = "scriptImportPath", EmitDefaultValue = true)]
        public string ScriptImportPath { get; set; }

        /// <summary>
        /// Gets or Sets ImportExtraFiles
        /// </summary>
        [DataMember(Name = "importExtraFiles", EmitDefaultValue = true)]
        public bool ImportExtraFiles { get; set; }

        /// <summary>
        /// Gets or Sets ExtraFileExtensions
        /// </summary>
        [DataMember(Name = "extraFileExtensions", EmitDefaultValue = true)]
        public string ExtraFileExtensions { get; set; }

        /// <summary>
        /// Gets or Sets EnableMediaInfo
        /// </summary>
        [DataMember(Name = "enableMediaInfo", EmitDefaultValue = true)]
        public bool EnableMediaInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaManagementConfigResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AutoUnmonitorPreviouslyDownloadedEpisodes: ").Append(AutoUnmonitorPreviouslyDownloadedEpisodes).Append("\n");
            sb.Append("  RecycleBin: ").Append(RecycleBin).Append("\n");
            sb.Append("  RecycleBinCleanupDays: ").Append(RecycleBinCleanupDays).Append("\n");
            sb.Append("  DownloadPropersAndRepacks: ").Append(DownloadPropersAndRepacks).Append("\n");
            sb.Append("  CreateEmptySeriesFolders: ").Append(CreateEmptySeriesFolders).Append("\n");
            sb.Append("  DeleteEmptyFolders: ").Append(DeleteEmptyFolders).Append("\n");
            sb.Append("  FileDate: ").Append(FileDate).Append("\n");
            sb.Append("  RescanAfterRefresh: ").Append(RescanAfterRefresh).Append("\n");
            sb.Append("  SetPermissionsLinux: ").Append(SetPermissionsLinux).Append("\n");
            sb.Append("  ChmodFolder: ").Append(ChmodFolder).Append("\n");
            sb.Append("  ChownGroup: ").Append(ChownGroup).Append("\n");
            sb.Append("  EpisodeTitleRequired: ").Append(EpisodeTitleRequired).Append("\n");
            sb.Append("  SkipFreeSpaceCheckWhenImporting: ").Append(SkipFreeSpaceCheckWhenImporting).Append("\n");
            sb.Append("  MinimumFreeSpaceWhenImporting: ").Append(MinimumFreeSpaceWhenImporting).Append("\n");
            sb.Append("  CopyUsingHardlinks: ").Append(CopyUsingHardlinks).Append("\n");
            sb.Append("  UseScriptImport: ").Append(UseScriptImport).Append("\n");
            sb.Append("  ScriptImportPath: ").Append(ScriptImportPath).Append("\n");
            sb.Append("  ImportExtraFiles: ").Append(ImportExtraFiles).Append("\n");
            sb.Append("  ExtraFileExtensions: ").Append(ExtraFileExtensions).Append("\n");
            sb.Append("  EnableMediaInfo: ").Append(EnableMediaInfo).Append("\n");
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
            return this.Equals(input as MediaManagementConfigResource);
        }

        /// <summary>
        /// Returns true if MediaManagementConfigResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaManagementConfigResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaManagementConfigResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.AutoUnmonitorPreviouslyDownloadedEpisodes == input.AutoUnmonitorPreviouslyDownloadedEpisodes ||
                    this.AutoUnmonitorPreviouslyDownloadedEpisodes.Equals(input.AutoUnmonitorPreviouslyDownloadedEpisodes)
                ) && 
                (
                    this.RecycleBin == input.RecycleBin ||
                    (this.RecycleBin != null &&
                    this.RecycleBin.Equals(input.RecycleBin))
                ) && 
                (
                    this.RecycleBinCleanupDays == input.RecycleBinCleanupDays ||
                    this.RecycleBinCleanupDays.Equals(input.RecycleBinCleanupDays)
                ) && 
                (
                    this.DownloadPropersAndRepacks == input.DownloadPropersAndRepacks ||
                    this.DownloadPropersAndRepacks.Equals(input.DownloadPropersAndRepacks)
                ) && 
                (
                    this.CreateEmptySeriesFolders == input.CreateEmptySeriesFolders ||
                    this.CreateEmptySeriesFolders.Equals(input.CreateEmptySeriesFolders)
                ) && 
                (
                    this.DeleteEmptyFolders == input.DeleteEmptyFolders ||
                    this.DeleteEmptyFolders.Equals(input.DeleteEmptyFolders)
                ) && 
                (
                    this.FileDate == input.FileDate ||
                    this.FileDate.Equals(input.FileDate)
                ) && 
                (
                    this.RescanAfterRefresh == input.RescanAfterRefresh ||
                    this.RescanAfterRefresh.Equals(input.RescanAfterRefresh)
                ) && 
                (
                    this.SetPermissionsLinux == input.SetPermissionsLinux ||
                    this.SetPermissionsLinux.Equals(input.SetPermissionsLinux)
                ) && 
                (
                    this.ChmodFolder == input.ChmodFolder ||
                    (this.ChmodFolder != null &&
                    this.ChmodFolder.Equals(input.ChmodFolder))
                ) && 
                (
                    this.ChownGroup == input.ChownGroup ||
                    (this.ChownGroup != null &&
                    this.ChownGroup.Equals(input.ChownGroup))
                ) && 
                (
                    this.EpisodeTitleRequired == input.EpisodeTitleRequired ||
                    this.EpisodeTitleRequired.Equals(input.EpisodeTitleRequired)
                ) && 
                (
                    this.SkipFreeSpaceCheckWhenImporting == input.SkipFreeSpaceCheckWhenImporting ||
                    this.SkipFreeSpaceCheckWhenImporting.Equals(input.SkipFreeSpaceCheckWhenImporting)
                ) && 
                (
                    this.MinimumFreeSpaceWhenImporting == input.MinimumFreeSpaceWhenImporting ||
                    this.MinimumFreeSpaceWhenImporting.Equals(input.MinimumFreeSpaceWhenImporting)
                ) && 
                (
                    this.CopyUsingHardlinks == input.CopyUsingHardlinks ||
                    this.CopyUsingHardlinks.Equals(input.CopyUsingHardlinks)
                ) && 
                (
                    this.UseScriptImport == input.UseScriptImport ||
                    this.UseScriptImport.Equals(input.UseScriptImport)
                ) && 
                (
                    this.ScriptImportPath == input.ScriptImportPath ||
                    (this.ScriptImportPath != null &&
                    this.ScriptImportPath.Equals(input.ScriptImportPath))
                ) && 
                (
                    this.ImportExtraFiles == input.ImportExtraFiles ||
                    this.ImportExtraFiles.Equals(input.ImportExtraFiles)
                ) && 
                (
                    this.ExtraFileExtensions == input.ExtraFileExtensions ||
                    (this.ExtraFileExtensions != null &&
                    this.ExtraFileExtensions.Equals(input.ExtraFileExtensions))
                ) && 
                (
                    this.EnableMediaInfo == input.EnableMediaInfo ||
                    this.EnableMediaInfo.Equals(input.EnableMediaInfo)
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
                hashCode = hashCode * 59 + this.AutoUnmonitorPreviouslyDownloadedEpisodes.GetHashCode();
                if (this.RecycleBin != null)
                    hashCode = hashCode * 59 + this.RecycleBin.GetHashCode();
                hashCode = hashCode * 59 + this.RecycleBinCleanupDays.GetHashCode();
                hashCode = hashCode * 59 + this.DownloadPropersAndRepacks.GetHashCode();
                hashCode = hashCode * 59 + this.CreateEmptySeriesFolders.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteEmptyFolders.GetHashCode();
                hashCode = hashCode * 59 + this.FileDate.GetHashCode();
                hashCode = hashCode * 59 + this.RescanAfterRefresh.GetHashCode();
                hashCode = hashCode * 59 + this.SetPermissionsLinux.GetHashCode();
                if (this.ChmodFolder != null)
                    hashCode = hashCode * 59 + this.ChmodFolder.GetHashCode();
                if (this.ChownGroup != null)
                    hashCode = hashCode * 59 + this.ChownGroup.GetHashCode();
                hashCode = hashCode * 59 + this.EpisodeTitleRequired.GetHashCode();
                hashCode = hashCode * 59 + this.SkipFreeSpaceCheckWhenImporting.GetHashCode();
                hashCode = hashCode * 59 + this.MinimumFreeSpaceWhenImporting.GetHashCode();
                hashCode = hashCode * 59 + this.CopyUsingHardlinks.GetHashCode();
                hashCode = hashCode * 59 + this.UseScriptImport.GetHashCode();
                if (this.ScriptImportPath != null)
                    hashCode = hashCode * 59 + this.ScriptImportPath.GetHashCode();
                hashCode = hashCode * 59 + this.ImportExtraFiles.GetHashCode();
                if (this.ExtraFileExtensions != null)
                    hashCode = hashCode * 59 + this.ExtraFileExtensions.GetHashCode();
                hashCode = hashCode * 59 + this.EnableMediaInfo.GetHashCode();
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
