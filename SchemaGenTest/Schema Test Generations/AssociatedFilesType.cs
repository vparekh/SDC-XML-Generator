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
[DataContractAttribute(Name="AssociatedFilesType", Namespace="http://healthIT.gov/sdc")]
public partial class AssociatedFilesType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<FileType> _file;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    [XmlElementAttribute("File", Order=0)]
    [DataMemberAttribute(Order=0)]
    public virtual BindingList<FileType> File
    {
        get
        {
            return _file;
        }
        set
        {
            if ((_file == value))
            {
                return;
            }
            if (((_file == null) 
                        || (_file.Equals(value) != true)))
            {
                _file = value;
                OnPropertyChanged("File", value);
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(AssociatedFilesType));
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
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current AssociatedFilesType object into an XML string
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
    /// Deserializes workflow markup into an AssociatedFilesType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output AssociatedFilesType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out AssociatedFilesType obj, out Exception exception)
    {
        exception = null;
        obj = default(AssociatedFilesType);
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
    
    public static bool Deserialize(string input, out AssociatedFilesType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static AssociatedFilesType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((AssociatedFilesType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static AssociatedFilesType Deserialize(Stream s)
    {
        return ((AssociatedFilesType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current AssociatedFilesType object into file
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
    /// Deserializes xml markup from file into an AssociatedFilesType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output AssociatedFilesType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out AssociatedFilesType obj, out Exception exception)
    {
        exception = null;
        obj = default(AssociatedFilesType);
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
    
    public static bool LoadFromFile(string fileName, out AssociatedFilesType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static AssociatedFilesType LoadFromFile(string fileName)
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
    /// Create a clone of this AssociatedFilesType object
    /// </summary>
    public virtual AssociatedFilesType Clone()
    {
        return ((AssociatedFilesType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore