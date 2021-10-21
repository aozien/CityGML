
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
public abstract partial class AbstractDQ_Element_Type : AbstractObject_Type {
    
    private CharacterString_PropertyType[] nameOfMeasureField;
    
    private MD_Identifier_PropertyType measureIdentificationField;
    
    private CharacterString_PropertyType measureDescriptionField;
    
    private DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodTypeField;
    
    private CharacterString_PropertyType evaluationMethodDescriptionField;
    
    private CI_Citation_PropertyType evaluationProcedureField;
    
    private DateTime_PropertyType[] dateTimeField;
    
    private DQ_Result_PropertyType[] resultField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("nameOfMeasure")]
    public CharacterString_PropertyType[] nameOfMeasure {
        get {
            return this.nameOfMeasureField;
        }
        set {
            this.nameOfMeasureField = value;
        }
    }
    
    /// <remarks/>
    public MD_Identifier_PropertyType measureIdentification {
        get {
            return this.measureIdentificationField;
        }
        set {
            this.measureIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType measureDescription {
        get {
            return this.measureDescriptionField;
        }
        set {
            this.measureDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodType {
        get {
            return this.evaluationMethodTypeField;
        }
        set {
            this.evaluationMethodTypeField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType evaluationMethodDescription {
        get {
            return this.evaluationMethodDescriptionField;
        }
        set {
            this.evaluationMethodDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public CI_Citation_PropertyType evaluationProcedure {
        get {
            return this.evaluationProcedureField;
        }
        set {
            this.evaluationProcedureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dateTime")]
    public DateTime_PropertyType[] dateTime {
        get {
            return this.dateTimeField;
        }
        set {
            this.dateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("result")]
    public DQ_Result_PropertyType[] result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
}
}