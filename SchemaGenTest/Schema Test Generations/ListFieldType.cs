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
/// This type represents a grouper for the list-like answer choices,which may be derived from either a set of answer choice lists (a List composed of ListItems) or or a list obtained from a LookupEndpoint URI.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://healthIT.gov/sdc")]
[DataContractAttribute(Name="ListFieldType", Namespace="http://healthIT.gov/sdc")]
public partial class ListFieldType : ExtensionBaseType
{
    
    private bool _shouldSerializeordered;
    
    private bool _shouldSerializemaxSelections;
    
    private bool _shouldSerializeminSelections;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private RichTextType _listHeaderText;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private DataTypes_DEType _defaultListItemDataType;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private CodeSystemType _defaultCodeSystem;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private ExtensionBaseType _item;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<ExclusiveItemPairsType> _illegalListItemPairings;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<IfThenType> _afterChange;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private BindingList<OnEventType> _onEvent;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _colTextDelimiter;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private byte _numCols;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private byte _storedCol;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private ushort _minSelections;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private ushort _maxSelections;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool _ordered;
    
    private static XmlSerializer serializer;
    
    private ObjectChangeTracker changeTrackerField;
    
    /// <summary>
    /// ListFieldType class constructor
    /// </summary>
    public ListFieldType()
    {
        _colTextDelimiter = "|";
        _numCols = ((byte)(1));
        _storedCol = ((byte)(1));
        _minSelections = ((ushort)(1));
        _maxSelections = ((ushort)(1));
        _ordered = true;
    }
    
    /// <summary>
    /// The header row for a set of list items.  If the list has more than one column, the column text is separated by the colTextDelimiter.
    /// </summary>
    [XmlElementAttribute(Order=0)]
    [DataMemberAttribute(Order=0)]
    public virtual RichTextType ListHeaderText
    {
        get
        {
            return _listHeaderText;
        }
        set
        {
            if ((_listHeaderText == value))
            {
                return;
            }
            if (((_listHeaderText == null) 
                        || (_listHeaderText.Equals(value) != true)))
            {
                _listHeaderText = value;
                OnPropertyChanged("ListHeaderText", value);
            }
        }
    }
    
    /// <summary>
    /// Data type enumeration derived from W3C XML Schema.  This element is used only if the ListItems are all associated with coded values from a single coding system.
    /// </summary>
    [XmlElementAttribute(Order=1)]
    [DataMemberAttribute(Order=1)]
    public virtual DataTypes_DEType DefaultListItemDataType
    {
        get
        {
            return _defaultListItemDataType;
        }
        set
        {
            if ((_defaultListItemDataType == value))
            {
                return;
            }
            if (((_defaultListItemDataType == null) 
                        || (_defaultListItemDataType.Equals(value) != true)))
            {
                _defaultListItemDataType = value;
                OnPropertyChanged("DefaultListItemDataType", value);
            }
        }
    }
    
    /// <summary>
    /// If coded values are used for items in a List (including ListItem and LookupEndPoint lists), then the default coding system should be specified here.  For ListItem nodes, any exceptions to the coding system may be specified on the individual ListItem nodes.  For LookupEndPoints, the endpoint data can optionally specify any exceptions in a dedicated CodeSystem column in the returned list data.
    /// </summary>
    [XmlElementAttribute(Order=2)]
    [DataMemberAttribute(Order=2)]
    public virtual CodeSystemType DefaultCodeSystem
    {
        get
        {
            return _defaultCodeSystem;
        }
        set
        {
            if ((_defaultCodeSystem == value))
            {
                return;
            }
            if (((_defaultCodeSystem == null) 
                        || (_defaultCodeSystem.Equals(value) != true)))
            {
                _defaultCodeSystem = value;
                OnPropertyChanged("DefaultCodeSystem", value);
            }
        }
    }
    
    [XmlElementAttribute("List", typeof(ListType), Order=3)]
    [XmlElementAttribute("LookupEndPoint", typeof(LookupEndPointType), Order=3)]
    [DataMemberAttribute(Name="List", Order=3)]
    public virtual ExtensionBaseType Item
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
    
    [XmlElementAttribute("IllegalListItemPairings", Order=4)]
    [DataMemberAttribute(Order=4)]
    public virtual BindingList<ExclusiveItemPairsType> IllegalListItemPairings
    {
        get
        {
            return _illegalListItemPairings;
        }
        set
        {
            if ((_illegalListItemPairings == value))
            {
                return;
            }
            if (((_illegalListItemPairings == null) 
                        || (_illegalListItemPairings.Equals(value) != true)))
            {
                _illegalListItemPairings = value;
                OnPropertyChanged("IllegalListItemPairings", value);
            }
        }
    }
    
    /// <summary>
    /// Event that occurs after List Field selections are changed.
    /// </summary>
    [XmlElementAttribute("AfterChange", Order=5)]
    [DataMemberAttribute(Order=5)]
    public virtual BindingList<IfThenType> AfterChange
    {
        get
        {
            return _afterChange;
        }
        set
        {
            if ((_afterChange == value))
            {
                return;
            }
            if (((_afterChange == null) 
                        || (_afterChange.Equals(value) != true)))
            {
                _afterChange = value;
                OnPropertyChanged("AfterChange", value);
            }
        }
    }
    
    [XmlElementAttribute("OnEvent", Order=6)]
    [DataMemberAttribute(Order=6)]
    public virtual BindingList<OnEventType> OnEvent
    {
        get
        {
            return _onEvent;
        }
        set
        {
            if ((_onEvent == value))
            {
                return;
            }
            if (((_onEvent == null) 
                        || (_onEvent.Equals(value) != true)))
            {
                _onEvent = value;
                OnPropertyChanged("OnEvent", value);
            }
        }
    }
    
    /// <summary>
    /// Character in the DisplayText that separates the columns and rows in a single or multi-column list.
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute("|")]
    [DataMember]
    public virtual string colTextDelimiter
    {
        get
        {
            return _colTextDelimiter;
        }
        set
        {
            if ((_colTextDelimiter == value))
            {
                return;
            }
            if (((_colTextDelimiter == null) 
                        || (_colTextDelimiter.Equals(value) != true)))
            {
                _colTextDelimiter = value;
                OnPropertyChanged("colTextDelimiter", value);
            }
        }
    }
    
    /// <summary>
    /// Number of columns in the list
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
    [DataMember]
    public virtual byte numCols
    {
        get
        {
            return _numCols;
        }
        set
        {
            if ((_numCols == value))
            {
                return;
            }
            if (((_numCols == null) 
                        || (_numCols.Equals(value) != true)))
            {
                _numCols = value;
                OnPropertyChanged("numCols", value);
            }
        }
    }
    
    /// <summary>
    /// Determines which column of the list is stored in a database.  This list is one-based.
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
    [DataMember]
    public virtual byte storedCol
    {
        get
        {
            return _storedCol;
        }
        set
        {
            if ((_storedCol == value))
            {
                return;
            }
            if (((_storedCol == null) 
                        || (_storedCol.Equals(value) != true)))
            {
                _storedCol = value;
                OnPropertyChanged("storedCol", value);
            }
        }
    }
    
    /// <summary>
    /// Minimum number of answer choices (list items) that must be selected by the user.  If set to 0, then this question need not be answered by the user.
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1")]
    [DataMember]
    public virtual ushort minSelections
    {
        get
        {
            return _minSelections;
        }
        set
        {
            if ((_minSelections == value))
            {
                return;
            }
            _shouldSerializeminSelections = true;
            if (((_minSelections == null) 
                        || (_minSelections.Equals(value) != true)))
            {
                _minSelections = value;
                OnPropertyChanged("minSelections", value);
            }
        }
    }
    
    /// <summary>
    /// Maximum number of answer choices (list items) that can be selected by the user.  Must be greater than or equal to minSelections, and no larger than the total number of list itmes.
    /// 
    /// A value of 0 indicates no limit to the number of selected list items (answers).  This effectively means that the question is multi-select. (Abbreviated as QM)
    /// 
    /// A value of 1 indicates that the question list is single-select.  (Abbreviated as QS)
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1")]
    [DataMember]
    public virtual ushort maxSelections
    {
        get
        {
            return _maxSelections;
        }
        set
        {
            if ((_maxSelections == value))
            {
                return;
            }
            _shouldSerializemaxSelections = true;
            if (((_maxSelections == null) 
                        || (_maxSelections.Equals(value) != true)))
            {
                _maxSelections = value;
                OnPropertyChanged("maxSelections", value);
            }
        }
    }
    
    /// <summary>
    /// If false, then the form implementation may change the order of items in the list.
    /// </summary>
    [XmlAttribute]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [DataMember]
    public virtual bool ordered
    {
        get
        {
            return _ordered;
        }
        set
        {
            if ((_ordered.Equals(value) != true))
            {
                _ordered = value;
                OnPropertyChanged("ordered", value);
            }
            _shouldSerializeordered = true;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(ListFieldType));
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
    /// Test whether minSelections should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminSelections()
    {
        if (_shouldSerializeminSelections)
        {
            return true;
        }
        return (_minSelections != default(ushort));
    }
    
    /// <summary>
    /// Test whether maxSelections should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxSelections()
    {
        if (_shouldSerializemaxSelections)
        {
            return true;
        }
        return (_maxSelections != default(ushort));
    }
    
    /// <summary>
    /// Test whether ordered should be serialized
    /// </summary>
    public virtual bool ShouldSerializeordered()
    {
        if (_shouldSerializeordered)
        {
            return true;
        }
        return (_ordered != default(bool));
    }
    
    /// <summary>
    /// Test whether ListHeaderText should be serialized
    /// </summary>
    public virtual bool ShouldSerializeListHeaderText()
    {
        return (_listHeaderText != null);
    }
    
    /// <summary>
    /// Test whether DefaultListItemDataType should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDefaultListItemDataType()
    {
        return (_defaultListItemDataType != null);
    }
    
    /// <summary>
    /// Test whether DefaultCodeSystem should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDefaultCodeSystem()
    {
        return (_defaultCodeSystem != null);
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (_item != null);
    }
    
    /// <summary>
    /// Test whether colTextDelimiter should be serialized
    /// </summary>
    public virtual bool ShouldSerializecolTextDelimiter()
    {
        return !string.IsNullOrEmpty(colTextDelimiter);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ListFieldType object into an XML string
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
    /// Deserializes workflow markup into an ListFieldType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output ListFieldType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out ListFieldType obj, out Exception exception)
    {
        exception = null;
        obj = default(ListFieldType);
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
    
    public static bool Deserialize(string input, out ListFieldType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static ListFieldType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((ListFieldType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static ListFieldType Deserialize(Stream s)
    {
        return ((ListFieldType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current ListFieldType object into file
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
    /// Deserializes xml markup from file into an ListFieldType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ListFieldType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out ListFieldType obj, out Exception exception)
    {
        exception = null;
        obj = default(ListFieldType);
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
    
    public static bool LoadFromFile(string fileName, out ListFieldType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public new static ListFieldType LoadFromFile(string fileName)
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
    /// Create a clone of this ListFieldType object
    /// </summary>
    public virtual ListFieldType Clone()
    {
        return ((ListFieldType)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
