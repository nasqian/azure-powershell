namespace Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Runtime.PowerShell;

    /// <summary>Represents a log file.</summary>
    [System.ComponentModel.TypeConverter(typeof(LogFileTypeConverter))]
    public partial class LogFile
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.LogFile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LogFile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.LogFile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LogFile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LogFile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.LogFile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LogFile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.LogFilePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).PropertiesType = (string) content.GetValueForProperty("PropertiesType",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).PropertiesType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).LastModifiedTime = (global::System.DateTime?) content.GetValueForProperty("LastModifiedTime",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).LastModifiedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).SizeInKb = (long?) content.GetValueForProperty("SizeInKb",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).SizeInKb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).Url, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.LogFile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LogFile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.LogFilePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).PropertiesType = (string) content.GetValueForProperty("PropertiesType",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).PropertiesType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).LastModifiedTime = (global::System.DateTime?) content.GetValueForProperty("LastModifiedTime",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).LastModifiedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).SizeInKb = (long?) content.GetValueForProperty("SizeInKb",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).SizeInKb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.ILogFileInternal)this).Url, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents a log file.
    [System.ComponentModel.TypeConverter(typeof(LogFileTypeConverter))]
    public partial interface ILogFile

    {

    }
}