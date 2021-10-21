
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
namespace CityGMLSharp.Tsml.V1_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/tsml/1.0")]
[System.Xml.Serialization.XmlRootAttribute("ObservationProcess", Namespace="http://www.opengis.net/tsml/1.0", IsNullable=false)]
public partial class ObservationProcessType : AbstractFeatureType {
    
    private ReferenceType processTypeField;
    
    private OM_ProcessPropertyType originatingProcessField;
    
    private string aggregationDurationField;
    
    private VerticalDatumPropertyType1 verticalDatumField;
    
    private string[] commentField;
    
    private ReferenceType processReferenceField;
    
    private ReferenceType[] inputField;
    
    private NamedValuePropertyType[] parameterField;
    
    private CI_ResponsibleParty_PropertyType operatorField;
    
    /// <remarks/>
    public ReferenceType processType {
        get {
            return this.processTypeField;
        }
        set {
            this.processTypeField = value;
        }
    }
    
    /// <remarks/>
    public OM_ProcessPropertyType originatingProcess {
        get {
            return this.originatingProcessField;
        }
        set {
            this.originatingProcessField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string aggregationDuration {
        get {
            return this.aggregationDurationField;
        }
        set {
            this.aggregationDurationField = value;
        }
    }
    
    /// <remarks/>
    public VerticalDatumPropertyType1 verticalDatum {
        get {
            return this.verticalDatumField;
        }
        set {
            this.verticalDatumField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("comment")]
    public string[] comment {
        get {
            return this.commentField;
        }
        set {
            this.commentField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType processReference {
        get {
            return this.processReferenceField;
        }
        set {
            this.processReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("input")]
    public ReferenceType[] input {
        get {
            return this.inputField;
        }
        set {
            this.inputField = value;
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
    public CI_ResponsibleParty_PropertyType @operator {
        get {
            return this.operatorField;
        }
        set {
            this.operatorField = value;
        }
    }
}
}