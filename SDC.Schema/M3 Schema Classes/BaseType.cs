// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
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
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;

[System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BoolType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataTypesDateTime_SType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataTypesDateTime_DEType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataTypesNumeric_SType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ChangeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ComplianceRuleType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DestinationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SubmissionRuleType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ProvenanceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AssociatedFilesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LanguageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ApprovalType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FileDatesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FileUsageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactsType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ChangedFieldType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ChangeLogType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VersionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FileType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RuleAutoSelectType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RulesCollectionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RulesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseBlockType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActValidateFormType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActPreviewReportType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActShowReportType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActShowMessageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActShowFormType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActSendReportType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActSaveResponsesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListFieldType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ChildItemsType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseFieldType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListItemResponseFieldType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifierType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PhoneType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EmailType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AddressType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(JobType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NameType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LinkType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EventType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OnEventType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifiedExtensionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DisplayedType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ButtonItemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RepeatingType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(QuestionItemBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(QuestionItemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SectionBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SectionItemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListItemBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListItemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InjectFormType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActInjectType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FormDesignType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActSetItemAttributeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActActionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ThenType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompareToType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IsBetweenType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NumListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BoolListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StrListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataTypesNumeric_DEType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CodingType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterItemType111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CodeSystemType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemNameType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActAddCodeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemNameAttributeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnListBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnNumListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncNumListType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SetFunctionNumListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnNumListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringSplitNumListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefNumListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RepeatsNumListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnIntegerListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncIntegerListType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnIntegerListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringSplitIntegerListType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefIntegerListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RepeatsIntegerListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnDateTimeListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncDateTimeListType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnDateTimeListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringSplitDateTimeListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefDateTimeListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RepeatsDateTimeListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnBoolListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncBoolListType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnBoolListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringSplitBoolListType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefBoolListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RepeatsBoolListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnStrListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncStrListType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnStrListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringSplitStrListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefStrListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RepeatsStrListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ForEachInList))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyListSetFunctionsListType111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputList_ReturnListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListConvertListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListRemoveAtIndexListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListFilterListType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListInsertAtIndexListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncListType00000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyFunctionsListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringPatternMatchListType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringSplitListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataTypes_DEType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ExceptionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnBaseType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnAtomicType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyFunctionsAtomicType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RuleSingleSelectionSetsType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RuleSelectionTestType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSelectionSetBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PredicateType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActSetValueBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IfType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(WatchedPropertyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FilterPredicateType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListFilterType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GetItemAttribValuesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ScriptCodeBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompareType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BetweenType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyFunctionsBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyConvertBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NumFunctionBoolType111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeMonadicFunctionsBooleanType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputList_ReturnBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListMonadicFunctionsBoolType111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListGetItemAtIndexBoolType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringFunctionsBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringIsNullOrEmptyBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringIsNullBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringIsEmptyBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringLikeBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringContainsBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringEndsWithBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringStartsWithBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefRuleBoolType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefBoolType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnDateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ScriptCodeDateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyFunctionsDateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncDateTimeType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringConvertDateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeAddFunctionsDateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeDiffFunctionsDateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeMonadicFunctionsDateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NiladicFunctionsDateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeFunctionsAnyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputList_ReturnDateTimeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListGetItemAtIndexDateTimeType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefRuleDateTimeType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefDateTimeType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnIntegerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncIntegerType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerFunctionInteger111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeCompareIntegerType111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputList_ReturnIntegerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnIntegerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StrListIndexOfIntegerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringLengthIntegerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringContainsIntegerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StrListCountIntegerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringCompareIntegerType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefRuleIntegerType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefIntegerType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnNumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ScriptCodeStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ParamNumType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NumTrigNumType111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyConvertNumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncNumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListAggregateNumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NumNumFunctionNumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GetNumAttrValueType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyFunctionsNumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyFunctionsNumListOrNumType111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputList_ReturnNumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListMonadicFunctionsNumType111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListGetItemAtIndexNumType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefRuleNumType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefNumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnAtomicOrListType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyFunctionsAnyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SetAttrValueType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActSetAttrValueType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ScriptCodeNumType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeFormatStringType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputList_ReturnStrType111))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListAggregateStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListConvertStringType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListGetItemAtIndexStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringFunctionsStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyConvertStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GetStrAttrValueType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnyFunctionsStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringReplaceAtIndexStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringReplacePatternStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringSubstringStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringTrimStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringToUpperStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(StringToLowerStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefRuleStrType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefStrType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputStr_ReturnType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefRuleType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InputList_ReturnAnyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListGetItemAtIndexAnyType000))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ScriptCodeAnyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FuncType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LookupEndPointType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GetAttrValueType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RefType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PhoneNumberType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EmailAddressType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RichTextType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActSendMessageType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BlobType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataTypes_SType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterValueType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ChangeTrackingType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReplacedIDsType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CodeMatchType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetItemNameType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CountryCodeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AreaCodeType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(yearMonthDuration_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(yearMonthDuration_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(XML_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(XML_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(unsignedShort_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(unsignedShort_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(unsignedLong_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(unsignedLong_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(unsignedInt_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(unsignedInt_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(unsignedByte_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(unsignedByte_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(time_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(time_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(string_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FileHashType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetItemXPathType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LanguageCodeISO6393_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(UnitsType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AcceptabilityType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(string_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(short_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(short_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(positiveInteger_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(positiveInteger_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(nonPositiveInteger_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(nonPositiveInteger_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(nonNegativeInteger_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(nonNegativeInteger_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(negativeInteger_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(negativeInteger_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(long_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(long_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(integer_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(integer_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(int_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(int_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(HTML_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(HTML_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(hexBinary_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(hexBinary_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gYearMonth_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gYearMonth_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gYear_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gYear_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gMonthDay_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gMonthDay_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gMonth_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gMonth_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gDay_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(gDay_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(float_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(float_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(duration_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(duration_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(double_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(double_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(decimal_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(decimal_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(dayTimeDuration_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(dayTimeDuration_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(dateTimeStamp_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(dateTimeStamp_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(dateTime_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(dateTime_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(date_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(date_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(byte_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(byte_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(boolean_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(boolean_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(base64Binary_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(HashType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(base64Binary_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(anyURI_Stype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetItemIDType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(anyURI_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(anyType_DEtype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CommentType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public abstract partial class BaseType
{
    
    #region Private fields
    private bool _shouldSerializeorder;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _name;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _type;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private string _styleClass;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private System.Nullable<decimal> _order;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Developer assigned identifier, similar to a unique control/object
    /// name, used to provide the ability for programmatic manipulation of an
    /// element.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public virtual string name
    {
        get
        {
            return this._name;
        }
        set
        {
            this._name = value;
        }
    }
    
    /// <summary>
    /// The @type attribute can contain custom metadata "tokens" for the
    /// element, chosen from a standardized list of terms. Tokens are short alphanumeric
    /// text strings, defined by the W3C Schema NMTOKEN specification, that are defined
    /// in an Implementation Guide. The type xsd:NMTOKEN represents a single string
    /// token. NMTOKEN values may consist of letters, digits, periods ( . ), hyphens ( -
    /// ), underscores ( _ ), and colons ( : ). They may start with any of these
    /// characters. (www.datypic.com/sc/xsd/t-xsd_NMTOKEN.html) @type tokens may be
    /// specific for one or more kinds of SDC elements. Multiple tokens in the type
    /// attribute should be separated by whitespace. Type tokens may be used to specify
    /// special handling by an application, and are usually used to define form display
    /// constraints, but may include other custom metadata as well. Style metadata
    /// should generally be handled with @styleClass rather than @type. @type token
    /// examples include: tooltip, statusLineText, alignTopLeft, align:bottom,
    /// _pageBreak-after, etc. @type metadata should generally not affect the
    /// information content of a form.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public virtual string type
    {
        get
        {
            return this._type;
        }
        set
        {
            this._type = value;
        }
    }
    
    /// <summary>
    /// Developer assigned class name for display styling, generally for
    /// use with an external style sheet.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public virtual string styleClass
    {
        get
        {
            return this._styleClass;
        }
        set
        {
            this._styleClass = value;
        }
    }
    
    /// <summary>
    /// @order allows the form template developer to define a sequential
    /// order for elements in a template. This serves the purpose of providing a
    /// definitive/original order to sections, questions, answer choices, etc., when
    /// required for display purposes. This is important when the original XML ordering
    /// may become disrupted due to the use of an implementation technology that does
    /// not natively support ordering (e.g., object collections), and it can also
    /// provide a check on the proper importing of the XML tree during
    /// implementation.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual decimal order
    {
        get
        {
            if (this._order.HasValue)
            {
                return this._order.Value;
            }
            else
            {
                return default(decimal);
            }
        }
        set
        {
            this._order = value;
            _shouldSerializeorder = true;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual bool orderSpecified
    {
        get
        {
            return this._order.HasValue;
        }
        set
        {
            if (value==false)
            {
                this._order = null;
            }
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(BaseType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether order should be serialized
    /// </summary>
    public virtual bool ShouldSerializeorder()
    {
        if (_shouldSerializeorder)
        {
            return true;
        }
        return (_order != default(decimal));
    }
    
    /// <summary>
    /// Test whether name should be serialized
    /// </summary>
    public virtual bool ShouldSerializename()
    {
        return !string.IsNullOrEmpty(name);
    }
    
    /// <summary>
    /// Test whether type should be serialized
    /// </summary>
    public virtual bool ShouldSerializetype()
    {
        return !string.IsNullOrEmpty(type);
    }
    
    /// <summary>
    /// Test whether styleClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializestyleClass()
    {
        return !string.IsNullOrEmpty(styleClass);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current BaseType object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize(System.Text.Encoding encoding)
    {
        System.IO.StreamReader streamReader = null;
        System.IO.MemoryStream memoryStream = null;
        try
        {
            memoryStream = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Encoding = encoding;
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.IndentChars = " ";
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new System.IO.StreamReader(memoryStream, encoding);
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
    
    public virtual string Serialize()
    {
        return Serialize(System.Text.Encoding.UTF8);
    }
    
    /// <summary>
    /// Deserializes workflow markup into an BaseType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output BaseType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out BaseType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(BaseType);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out BaseType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public static BaseType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((BaseType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static BaseType Deserialize(System.IO.Stream s)
    {
        return ((BaseType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current BaseType object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName, encoding);
            return true;
        }
        catch (System.Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
        return SaveToFile(fileName, System.Text.Encoding.UTF8, out exception);
    }
    
    public virtual void SaveToFile(string fileName)
    {
        SaveToFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
    {
        System.IO.StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize(encoding);
            streamWriter = new System.IO.StreamWriter(fileName, false, encoding);
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
    /// Deserializes xml markup from file into an BaseType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output BaseType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out BaseType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(BaseType);
        try
        {
            obj = LoadFromFile(fileName, encoding);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out BaseType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out BaseType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static BaseType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public static BaseType LoadFromFile(string fileName, System.Text.Encoding encoding)
    {
        System.IO.FileStream file = null;
        System.IO.StreamReader sr = null;
        try
        {
            file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new System.IO.StreamReader(file, encoding);
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
}
}
#pragma warning restore