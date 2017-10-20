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
/// Web service that returns a value using the data type required by the parent Response field.
/// </summary>
[XmlIncludeAttribute(typeof(LookupEndPointType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="WebServiceType", Namespace="http://healthIT.gov/sdc")]
public partial class WebServiceType : ExtensionBaseType
{
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<RichTextType> _otherText;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private anyURI_Stype _uRI;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private RichTextType _security;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<ParameterType> _parameter;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    /// <summary>
    /// OtherText is any type of secondary text that is associated with any form item (e.g., section, question, list item) in any context.  The Description context is specified by the @type attribute.  Examples of Description @type values may include:
    /// -alternate language representations,
    /// -explanations for the user of the form,
    /// -tooltips,
    /// -pop-up help,
    /// -outlining (such as question numbering)
    /// 
    /// The @type enumerations must be defined and documented for the particular use case, and are currently out of scope in this schema definition.
    /// </summary>
    [XmlElementAttribute("OtherText", Order=0)]
    [DataMemberAttribute(Order=0)]
    public virtual BindingList<RichTextType> OtherText
    {
        get
        {
            return _otherText;
        }
        set
        {
            if ((_otherText == value))
            {
                return;
            }
            if (((_otherText == null) 
                        || (_otherText.Equals(value) != true)))
            {
                _otherText = value;
                OnPropertyChanged("OtherText", value);
            }
        }
    }
    
    /// <summary>
    /// THe URI/URL may use the parameter list and transmit the item name, property and value for each parameter.  The URI must understand the parameters and return an appropriate repsonse of the correct data type.  Guidelines for URI/URI construction syntax will be defined external to this Schema.
    /// </summary>
    [XmlElementAttribute(Order=1)]
    [DataMemberAttribute(Order=1)]
    public virtual anyURI_Stype URI
    {
        get
        {
            return _uRI;
        }
        set
        {
            if ((_uRI == value))
            {
                return;
            }
            if (((_uRI == null) 
                        || (_uRI.Equals(value) != true)))
            {
                _uRI = value;
                OnPropertyChanged("URI", value);
            }
        }
    }
    
    /// <summary>
    /// Information about securly accessing the web service.  More detailed service patterns may be required.
    /// </summary>
    [XmlElementAttribute(Order=2)]
    [DataMemberAttribute(Order=2)]
    public virtual RichTextType Security
    {
        get
        {
            return _security;
        }
        set
        {
            if ((_security == value))
            {
                return;
            }
            if (((_security == null) 
                        || (_security.Equals(value) != true)))
            {
                _security = value;
                OnPropertyChanged("Security", value);
            }
        }
    }
    
    /// <summary>
    /// Parameters are named FormDesign items which have property values that need to be supplied to a scripted function or a web service URI.
    /// </summary>
    [XmlElementAttribute("Parameter", Order=3)]
    [DataMemberAttribute(Order=3)]
    public virtual BindingList<ParameterType> Parameter
    {
        get
        {
            return _parameter;
        }
        set
        {
            if ((_parameter == value))
            {
                return;
            }
            if (((_parameter == null) 
                        || (_parameter.Equals(value) != true)))
            {
                _parameter = value;
                OnPropertyChanged("Parameter", value);
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(WebServiceType));
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
    /// Test whether URI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeURI()
    {
        return (_uRI != null);
    }
    
    /// <summary>
    /// Test whether Security should be serialized
    /// </summary>
    public virtual bool ShouldSerializeSecurity()
    {
        return (_security != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current WebServiceType object into an XML string
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
    /// Deserializes workflow markup into an WebServiceType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output WebServiceType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out WebServiceType obj, out Exception exception)
    {
        exception = null;
        obj = default(WebServiceType);
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
    
    public static bool Deserialize(string input, out WebServiceType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static WebServiceType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((WebServiceType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static WebServiceType Deserialize(Stream s)
    {
        return ((WebServiceType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current WebServiceType object into file
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
    /// Deserializes xml markup from file into an WebServiceType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output WebServiceType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out WebServiceType obj, out Exception exception)
    {
        exception = null;
        obj = default(WebServiceType);
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
    
    public static bool LoadFromFile(string fileName, out WebServiceType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static WebServiceType LoadFromFile(string fileName)
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
    /// Create a clone of this WebServiceType object
    /// </summary>
    public virtual WebServiceType Clone()
    {
        return ((WebServiceType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
