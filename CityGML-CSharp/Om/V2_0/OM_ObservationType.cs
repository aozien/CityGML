
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
namespace CityGMLSharp.Om.V2_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/om/2.0")]
[System.Xml.Serialization.XmlRootAttribute("OM_Observation", Namespace="http://www.opengis.net/om/2.0", IsNullable=false)]
public partial class OM_ObservationType : AbstractFeatureType {
    
    private ReferenceType typeField;
    
    private MD_Metadata_PropertyType metadataField;
    
    private ObservationContextPropertyType[] relatedObservationField;
    
    private TimeObjectPropertyType phenomenonTimeField;
    
    private TimeInstantPropertyType resultTimeField;
    
    private TimePeriodPropertyType validTimeField;
    
    private OM_ProcessPropertyType procedureField;
    
    private NamedValuePropertyType[] parameterField;
    
    private ReferenceType observedPropertyField;
    
    private FeaturePropertyType featureOfInterestField;
    
    private DQ_Element_PropertyType[] resultQualityField;
    
    private object resultField;
    
    /// <remarks/>
    public ReferenceType type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    public MD_Metadata_PropertyType metadata {
        get {
            return this.metadataField;
        }
        set {
            this.metadataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("relatedObservation")]
    public ObservationContextPropertyType[] relatedObservation {
        get {
            return this.relatedObservationField;
        }
        set {
            this.relatedObservationField = value;
        }
    }
    
    /// <remarks/>
    public TimeObjectPropertyType phenomenonTime {
        get {
            return this.phenomenonTimeField;
        }
        set {
            this.phenomenonTimeField = value;
        }
    }
    
    /// <remarks/>
    public TimeInstantPropertyType resultTime {
        get {
            return this.resultTimeField;
        }
        set {
            this.resultTimeField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodPropertyType validTime {
        get {
            return this.validTimeField;
        }
        set {
            this.validTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public OM_ProcessPropertyType procedure {
        get {
            return this.procedureField;
        }
        set {
            this.procedureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parameter")]
    public NamedValuePropertyType[] parameter {
        get {
            return this.parameterField;
        }
        set {
            this.parameterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public ReferenceType observedProperty {
        get {
            return this.observedPropertyField;
        }
        set {
            this.observedPropertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public FeaturePropertyType featureOfInterest {
        get {
            return this.featureOfInterestField;
        }
        set {
            this.featureOfInterestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("resultQuality")]
    public DQ_Element_PropertyType[] resultQuality {
        get {
            return this.resultQualityField;
        }
        set {
            this.resultQualityField = value;
        }
    }
    
    /// <remarks/>
    public object result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
}
}