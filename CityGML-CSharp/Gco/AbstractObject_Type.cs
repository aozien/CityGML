
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
namespace CityGMLSharp.Gco
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiplicityRange_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Multiplicity_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Association_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractRS_ReferenceSystem_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_DataSet_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDS_Aggregate_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Initiative_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Series_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_ProductionSeries_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Sensor_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_Platform_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_OtherAggregate_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DS_StereoMate_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_ApplicationSchemaInformation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_PortrayalCatalogueReference_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LI_Source_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LI_ProcessStep_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LI_Lineage_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_Scope_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_DataQuality_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Distribution_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TypeName_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MemberName_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_RangeDimension_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Band_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractMD_ContentInformation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_CoverageDescription_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_ImageDescription_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_FeatureCatalogueDescription_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_Result_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_QuantitativeResult_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_ConformanceResult_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_Element_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_Completeness_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_CompletenessCommission_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_CompletenessOmission_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_LogicalConsistency_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_ConceptualConsistency_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_DomainConsistency_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_FormatConsistency_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_TopologicalConsistency_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_PositionalAccuracy_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_AbsoluteExternalPositionalAccuracy_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_GriddedDataPositionalAccuracy_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_RelativeInternalPositionalAccuracy_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_ThematicAccuracy_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_ThematicClassificationCorrectness_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_NonQuantitativeAttributeAccuracy_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_QuantitativeAttributeAccuracy_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_TemporalAccuracy_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_AccuracyOfATimeMeasurement_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_TemporalConsistency_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_TemporalValidity_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_VerticalExtent_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractEX_GeographicExtent_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_GeographicDescription_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_GeographicBoundingBox_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_BoundingPolygon_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_Extent_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_RepresentativeFraction_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_AggregateInformation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Constraints_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_SecurityConstraints_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_LegalConstraints_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Usage_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Keywords_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Medium_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_DigitalTransferOptions_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_StandardOrderProcess_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Distributor_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Format_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_BrowseGraphic_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_MaintenanceInformation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractMD_Identification_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_ServiceIdentification_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_DataIdentification_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_ExtendedElementInformation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_MetadataExtensionInformation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_ReferenceSystem_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_GeometricObjects_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Series_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Identifier_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RS_Identifier_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Date_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Citation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Dimension_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractMD_SpatialRepresentation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_VectorSpatialRepresentation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_GridSpatialRepresentation_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Georectified_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Georeferenceable_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PT_Locale_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_OnlineResource_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Address_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Telephone_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Contact_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_ResponsibleParty_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PT_FreeText_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Metadata_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_TemporalExtent_Type))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_SpatialTemporalExtent_Type))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
public abstract partial class AbstractObject_Type {
    
    private string idField;
    
    private string uuidField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uuid {
        get {
            return this.uuidField;
        }
        set {
            this.uuidField = value;
        }
    }
}
}