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

/// <summary>
/// Standard structure for including Binary Large Objects (Blobs) in XML
/// templates. Blobs can handle any type of binary media, such as images, audio, video,
/// and data streams of any specified format (such as a MIME type).
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="BlobType", Namespace="http://healthIT.gov/sdc")]
public partial class BlobType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<RichTextType> _description;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private HashType _hash;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BaseType _item;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _mimeType;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _fileExtension;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    [XmlElementAttribute("Description", Order=0)]
    [DataMemberAttribute(Order=0)]
    public virtual BindingList<RichTextType> Description
    {
        get
        {
            return _description;
        }
        set
        {
            if ((_description == value))
            {
                return;
            }
            if (((_description == null) 
                        || (_description.Equals(value) != true)))
            {
                _description = value;
                OnPropertyChanged("Description", value);
            }
        }
    }
    
    /// <summary>
    /// Binary hash of the blob data
    /// </summary>
    [XmlElementAttribute(Order=1)]
    [DataMemberAttribute(Order=1)]
    public virtual HashType Hash
    {
        get
        {
            return _hash;
        }
        set
        {
            if ((_hash == value))
            {
                return;
            }
            if (((_hash == null) 
                        || (_hash.Equals(value) != true)))
            {
                _hash = value;
                OnPropertyChanged("Hash", value);
            }
        }
    }
    
    [XmlElementAttribute("BinaryMediaBase64", typeof(base64Binary_Stype), Order=2)]
    [XmlElementAttribute("BlobURI", typeof(anyURI_Stype), Order=2)]
    [DataMemberAttribute(Name="BinaryMediaBase64", Order=2)]
    public virtual BaseType Item
    {
        get
        {
            return _item;
        }
        set
        {
            if ((_item == value))
            {
                return;
            }
            if (((_item == null) 
                        || (_item.Equals(value) != true)))
            {
                _item = value;
                OnPropertyChanged("Item", value);
            }
        }
    }
    
    /// <summary>
    /// TBD: Must be a valid MIME type - needs enumeration
    /// </summary>
    [XmlAttribute]
    [DataMember]
    public virtual string mimeType
    {
        get
        {
            return _mimeType;
        }
        set
        {
            if ((_mimeType == value))
            {
                return;
            }
            if (((_mimeType == null) 
                        || (_mimeType.Equals(value) != true)))
            {
                _mimeType = value;
                OnPropertyChanged("mimeType", value);
            }
        }
    }
    
    /// <summary>
    /// Use a common file extension (e.g., docx) if there is no @MIME_Type available
    /// </summary>
    [XmlAttribute]
    [DataMember]
    public virtual string fileExtension
    {
        get
        {
            return _fileExtension;
        }
        set
        {
            if ((_fileExtension == value))
            {
                return;
            }
            if (((_fileExtension == null) 
                        || (_fileExtension.Equals(value) != true)))
            {
                _fileExtension = value;
                OnPropertyChanged("fileExtension", value);
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(BlobType));
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
    /// Test whether Hash should be serialized
    /// </summary>
    public virtual bool ShouldSerializeHash()
    {
        return (_hash != null);
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (_item != null);
    }
    
    /// <summary>
    /// Test whether mimeType should be serialized
    /// </summary>
    public virtual bool ShouldSerializemimeType()
    {
        return !string.IsNullOrEmpty(mimeType);
    }
    
    /// <summary>
    /// Test whether fileExtension should be serialized
    /// </summary>
    public virtual bool ShouldSerializefileExtension()
    {
        return !string.IsNullOrEmpty(fileExtension);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current BlobType object into an XML string
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
    /// Deserializes workflow markup into an BlobType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output BlobType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out BlobType obj, out Exception exception)
    {
        exception = null;
        obj = default(BlobType);
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
    
    public static bool Deserialize(string input, out BlobType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static BlobType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((BlobType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static BlobType Deserialize(Stream s)
    {
        return ((BlobType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current BlobType object into file
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
    /// Deserializes xml markup from file into an BlobType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output BlobType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out BlobType obj, out Exception exception)
    {
        exception = null;
        obj = default(BlobType);
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
    
    public static bool LoadFromFile(string fileName, out BlobType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static BlobType LoadFromFile(string fileName)
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
    /// Create a clone of this BlobType object
    /// </summary>
    public virtual BlobType Clone()
    {
        return ((BlobType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
