
/**
* @author aozien
*/

// Granted under LGPL-2.0 License
// Copyright (c) 2021 Abdulrahman Zien https://github.com/aozien, files were generated based on the schema specs
 
using System;
using System.Xml.Serialization;

using CityGMLSharp.Citygml.Appearance.V3_0;
using CityGMLSharp.Gml.V3_2;
using CityGMLSharp.SamplingSpatial.V2_0;
using CityGMLSharp.Om.V2_0;
using CityGMLSharp.Gmd;
using CityGMLSharp.Gco;
using CityGMLSharp.Gss;
using CityGMLSharp.Gml;
using CityGMLSharp.Gts;
using CityGMLSharp.Gsr;
using CityGMLSharp.Citygml.Cityobjectgroup.V3_0;
using CityGMLSharp.Citygml.V3_0;
using CityGMLSharp.Tsml.V1_0;
using CityGMLSharp.Citygml.Generics.V3_0;
using CityGMLSharp.Citygml.Dynamizer.V3_0;
using CityGMLSharp.Swe.V2_0;
using CityGMLSharp.Gmlcov.V1_0;
using CityGMLSharp.Sos.V2_0;
using CityGMLSharp.Swes.V2_0;
using CityGMLSharp.Citygml.Versioning.V3_0;
using CityGMLSharp.Citygml.Waterbody.V3_0;
using CityGMLSharp.Citygml.Landuse.V3_0;
using CityGMLSharp.Citygml.Construction.V3_0;
using CityGMLSharp.Urn_oasis_names_tc_ciq_xsdschema_xAL_2_0;
using CityGMLSharp.Citygml.Transportation.V3_0;
using CityGMLSharp.Citygml.Relief.V3_0;
using CityGMLSharp.Citygml.Building.V3_0;
using CityGMLSharp.Citygml.Tunnel.V3_0;
using CityGMLSharp.Citygml.Bridge.V3_0;
using CityGMLSharp.Citygml.Vegetation.V3_0;
using CityGMLSharp.Citygml.Cityfurniture.V3_0;
using CityGMLSharp.Sampling.V2_0;
using CityGMLSharp.Addressing;
using CityGMLSharp.Fes.V2_0;
using CityGMLSharp.Ows.V1_1;
using CityGMLSharp.Wsn.T_1;
namespace CityGMLSharp.Gmd
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
[System.Xml.Serialization.XmlRootAttribute("MD_Metadata", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
public partial class MD_Metadata_Type : AbstractObject_Type {
    
    private CharacterString_PropertyType fileIdentifierField;
    
    private CharacterString_PropertyType languageField;
    
    private MD_CharacterSetCode_PropertyType characterSetField;
    
    private CharacterString_PropertyType parentIdentifierField;
    
    private MD_ScopeCode_PropertyType[] hierarchyLevelField;
    
    private CharacterString_PropertyType[] hierarchyLevelNameField;
    
    private CI_ResponsibleParty_PropertyType[] contactField;
    
    private Date_PropertyType dateStampField;
    
    private CharacterString_PropertyType metadataStandardNameField;
    
    private CharacterString_PropertyType metadataStandardVersionField;
    
    private CharacterString_PropertyType dataSetURIField;
    
    private PT_Locale_PropertyType[] localeField;
    
    private MD_SpatialRepresentation_PropertyType[] spatialRepresentationInfoField;
    
    private MD_ReferenceSystem_PropertyType[] referenceSystemInfoField;
    
    private MD_MetadataExtensionInformation_PropertyType[] metadataExtensionInfoField;
    
    private MD_Identification_PropertyType[] identificationInfoField;
    
    private MD_ContentInformation_PropertyType[] contentInfoField;
    
    private MD_Distribution_PropertyType distributionInfoField;
    
    private DQ_DataQuality_PropertyType[] dataQualityInfoField;
    
    private MD_PortrayalCatalogueReference_PropertyType[] portrayalCatalogueInfoField;
    
    private MD_Constraints_PropertyType[] metadataConstraintsField;
    
    private MD_ApplicationSchemaInformation_PropertyType[] applicationSchemaInfoField;
    
    private MD_MaintenanceInformation_PropertyType metadataMaintenanceField;
    
    private DS_Aggregate_PropertyType[] seriesField;
    
    private DS_DataSet_PropertyType[] describesField;
    
    private ObjectReference_PropertyType[] propertyTypeField;
    
    private ObjectReference_PropertyType[] featureTypeField;
    
    private ObjectReference_PropertyType[] featureAttributeField;
    
    /// <remarks/>
    public CharacterString_PropertyType fileIdentifier {
        get {
            return this.fileIdentifierField;
        }
        set {
            this.fileIdentifierField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
    
    /// <remarks/>
    public MD_CharacterSetCode_PropertyType characterSet {
        get {
            return this.characterSetField;
        }
        set {
            this.characterSetField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType parentIdentifier {
        get {
            return this.parentIdentifierField;
        }
        set {
            this.parentIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hierarchyLevel")]
    public MD_ScopeCode_PropertyType[] hierarchyLevel {
        get {
            return this.hierarchyLevelField;
        }
        set {
            this.hierarchyLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hierarchyLevelName")]
    public CharacterString_PropertyType[] hierarchyLevelName {
        get {
            return this.hierarchyLevelNameField;
        }
        set {
            this.hierarchyLevelNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("contact")]
    public CI_ResponsibleParty_PropertyType[] contact {
        get {
            return this.contactField;
        }
        set {
            this.contactField = value;
        }
    }
    
    /// <remarks/>
    public Date_PropertyType dateStamp {
        get {
            return this.dateStampField;
        }
        set {
            this.dateStampField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType metadataStandardName {
        get {
            return this.metadataStandardNameField;
        }
        set {
            this.metadataStandardNameField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType metadataStandardVersion {
        get {
            return this.metadataStandardVersionField;
        }
        set {
            this.metadataStandardVersionField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType dataSetURI {
        get {
            return this.dataSetURIField;
        }
        set {
            this.dataSetURIField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("locale")]
    public PT_Locale_PropertyType[] locale {
        get {
            return this.localeField;
        }
        set {
            this.localeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("spatialRepresentationInfo")]
    public MD_SpatialRepresentation_PropertyType[] spatialRepresentationInfo {
        get {
            return this.spatialRepresentationInfoField;
        }
        set {
            this.spatialRepresentationInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("referenceSystemInfo")]
    public MD_ReferenceSystem_PropertyType[] referenceSystemInfo {
        get {
            return this.referenceSystemInfoField;
        }
        set {
            this.referenceSystemInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("metadataExtensionInfo")]
    public MD_MetadataExtensionInformation_PropertyType[] metadataExtensionInfo {
        get {
            return this.metadataExtensionInfoField;
        }
        set {
            this.metadataExtensionInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("identificationInfo")]
    public MD_Identification_PropertyType[] identificationInfo {
        get {
            return this.identificationInfoField;
        }
        set {
            this.identificationInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("contentInfo")]
    public MD_ContentInformation_PropertyType[] contentInfo {
        get {
            return this.contentInfoField;
        }
        set {
            this.contentInfoField = value;
        }
    }
    
    /// <remarks/>
    public MD_Distribution_PropertyType distributionInfo {
        get {
            return this.distributionInfoField;
        }
        set {
            this.distributionInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataQualityInfo")]
    public DQ_DataQuality_PropertyType[] dataQualityInfo {
        get {
            return this.dataQualityInfoField;
        }
        set {
            this.dataQualityInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("portrayalCatalogueInfo")]
    public MD_PortrayalCatalogueReference_PropertyType[] portrayalCatalogueInfo {
        get {
            return this.portrayalCatalogueInfoField;
        }
        set {
            this.portrayalCatalogueInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("metadataConstraints")]
    public MD_Constraints_PropertyType[] metadataConstraints {
        get {
            return this.metadataConstraintsField;
        }
        set {
            this.metadataConstraintsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("applicationSchemaInfo")]
    public MD_ApplicationSchemaInformation_PropertyType[] applicationSchemaInfo {
        get {
            return this.applicationSchemaInfoField;
        }
        set {
            this.applicationSchemaInfoField = value;
        }
    }
    
    /// <remarks/>
    public MD_MaintenanceInformation_PropertyType metadataMaintenance {
        get {
            return this.metadataMaintenanceField;
        }
        set {
            this.metadataMaintenanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("series")]
    public DS_Aggregate_PropertyType[] series {
        get {
            return this.seriesField;
        }
        set {
            this.seriesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("describes")]
    public DS_DataSet_PropertyType[] describes {
        get {
            return this.describesField;
        }
        set {
            this.describesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("propertyType")]
    public ObjectReference_PropertyType[] propertyType {
        get {
            return this.propertyTypeField;
        }
        set {
            this.propertyTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("featureType")]
    public ObjectReference_PropertyType[] featureType {
        get {
            return this.featureTypeField;
        }
        set {
            this.featureTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("featureAttribute")]
    public ObjectReference_PropertyType[] featureAttribute {
        get {
            return this.featureAttributeField;
        }
        set {
            this.featureAttributeField = value;
        }
    }
}
}