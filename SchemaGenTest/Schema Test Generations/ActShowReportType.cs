// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.15
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace SDC
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.Reflection;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="ActShowReportType", Namespace="http://healthIT.gov/sdc")]
public partial class ActShowReportType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _reportID;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _packageID;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _reportInstanceGuid;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _displayState;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    /// <summary>
    /// This ID represents the report to be displayed.
    /// </summary>
    [XmlAttributeAttribute(DataType="anyURI")]
    [DataMember]
    public virtual string reportID
    {
        get
        {
            return _reportID;
        }
        set
        {
            if ((_reportID == value))
            {
                return;
            }
            if (((_reportID == null) 
                        || (_reportID.Equals(value) != true)))
            {
                _reportID = value;
                OnPropertyChanged("reportID", value);
            }
        }
    }
    
    /// <summary>
    /// This ID represents the Package that contains the report to be displayed.
    /// </summary>
    [XmlAttributeAttribute(DataType="anyURI")]
    [DataMember]
    public virtual string packageID
    {
        get
        {
            return _packageID;
        }
        set
        {
            if ((_packageID == value))
            {
                return;
            }
            if (((_packageID == null) 
                        || (_packageID.Equals(value) != true)))
            {
                _packageID = value;
                OnPropertyChanged("packageID", value);
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual string reportInstanceGuid
    {
        get
        {
            return _reportInstanceGuid;
        }
        set
        {
            if ((_reportInstanceGuid == value))
            {
                return;
            }
            if (((_reportInstanceGuid == null) 
                        || (_reportInstanceGuid.Equals(value) != true)))
            {
                _reportInstanceGuid = value;
                OnPropertyChanged("reportInstanceGuid", value);
            }
        }
    }
    
    [XmlAttribute]
    [DataMember]
    public virtual string displayState
    {
        get
        {
            return _displayState;
        }
        set
        {
            if ((_displayState == value))
            {
                return;
            }
            if (((_displayState == null) 
                        || (_displayState.Equals(value) != true)))
            {
                _displayState = value;
                OnPropertyChanged("displayState", value);
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(ActShowReportType));
            }
            return serializer;
        }
    }
    
    [XmlIgnore()]
    public ObjectChangeTracker ChangeTracker
    {
        get
        {
            if ((changeTrackerField == null))
            {
                changeTrackerField = new ObjectChangeTracker(this);
            }
            return changeTrackerField;
        }
    }
    
    /// <summary>
    /// Test whether reportID should be serialized
    /// </summary>
    public virtual bool ShouldSerializereportID()
    {
        return !string.IsNullOrEmpty(reportID);
    }
    
    /// <summary>
    /// Test whether packageID should be serialized
    /// </summary>
    public virtual bool ShouldSerializepackageID()
    {
        return !string.IsNullOrEmpty(packageID);
    }
    
    /// <summary>
    /// Test whether reportInstanceGuid should be serialized
    /// </summary>
    public virtual bool ShouldSerializereportInstanceGuid()
    {
        return !string.IsNullOrEmpty(reportInstanceGuid);
    }
    
    /// <summary>
    /// Test whether displayState should be serialized
    /// </summary>
    public virtual bool ShouldSerializedisplayState()
    {
        return !string.IsNullOrEmpty(displayState);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ActShowReportType object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
        StreamReader streamReader = null;
        MemoryStream memoryStream = null;
        try
        {
            memoryStream = new MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }
        finally
        {
            if ((streamReader != null))
            {
                streamReader.Dispose();
            }
            if ((memoryStream != null))
            {
                memoryStream.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes workflow markup into an ActShowReportType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output ActShowReportType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out ActShowReportType obj, out Exception exception)
    {
        exception = null;
        obj = default(ActShowReportType);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out ActShowReportType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static ActShowReportType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((ActShowReportType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static ActShowReportType Deserialize(Stream s)
    {
        return ((ActShowReportType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current ActShowReportType object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName);
            return true;
        }
        catch (Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual void SaveToFile(string fileName)
    {
        StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize();
            FileInfo xmlFile = new FileInfo(fileName);
            streamWriter = xmlFile.CreateText();
            streamWriter.WriteLine(xmlString);
            streamWriter.Close();
        }
        finally
        {
            if ((streamWriter != null))
            {
                streamWriter.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes xml markup from file into an ActShowReportType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ActShowReportType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ActShowReportType obj, out Exception exception)
    {
        exception = null;
        obj = default(ActShowReportType);
        try
        {
            obj = LoadFromFile(fileName);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out ActShowReportType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static ActShowReportType LoadFromFile(string fileName)
    {
        FileStream file = null;
        StreamReader sr = null;
        try
        {
            file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(file);
            string xmlString = sr.ReadToEnd();
            sr.Close();
            file.Close();
            return Deserialize(xmlString);
        }
        finally
        {
            if ((file != null))
            {
                file.Dispose();
            }
            if ((sr != null))
            {
                sr.Dispose();
            }
        }
    }
    
    #region Clone method
    /// <summary>
    /// Create a clone of this ActShowReportType object
    /// </summary>
    public virtual ActShowReportType Clone()
    {
        return ((ActShowReportType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
