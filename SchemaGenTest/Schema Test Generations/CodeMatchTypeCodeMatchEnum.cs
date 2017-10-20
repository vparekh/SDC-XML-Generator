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
[XmlTypeAttribute(AnonymousType=true, Namespace="http://healthIT.gov/sdc")]
public enum CodeMatchTypeCodeMatchEnum
{
    
    [XmlEnumAttribute("Exact Code Match")]
    ExactCodeMatch,
    
    [XmlEnumAttribute("Close Code Match")]
    CloseCodeMatch,
    
    [XmlEnumAttribute("Code Broader Than Item")]
    CodeBroaderThanItem,
    
    [XmlEnumAttribute("Code Narrower Than Item")]
    CodeNarrowerThanItem,
    
    [XmlEnumAttribute("Item Implements Data Element Exactly")]
    ItemImplementsDataElementExactly,
    
    [XmlEnumAttribute("Item Derived From Data Element")]
    ItemDerivedFromDataElement,
    
    [XmlEnumAttribute("Item Related To Data Element")]
    ItemRelatedToDataElement,
}
}
#pragma warning restore