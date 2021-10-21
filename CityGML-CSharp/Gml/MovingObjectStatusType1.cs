
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
namespace CityGMLSharp.Gml
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="MovingObjectStatusType", Namespace="http://www.opengis.net/gml")]
[System.Xml.Serialization.XmlRootAttribute("MovingObjectStatus", Namespace="http://www.opengis.net/gml", IsNullable=false)]
public partial class MovingObjectStatusType1 : AbstractTimeSliceType1 {
    
    private object itemField;
    
    private MeasureType1 speedField;
    
    private DirectionPropertyType1 bearingField;
    
    private MeasureType1 accelerationField;
    
    private MeasureType1 elevationField;
    
    private StringOrRefType1 statusField;
    
    private ReferenceType1 statusReferenceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("location", typeof(LocationPropertyType1))]
    [System.Xml.Serialization.XmlElementAttribute("locationName", typeof(CodeType1))]
    [System.Xml.Serialization.XmlElementAttribute("locationReference", typeof(ReferenceType1))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType1))]
    [System.Xml.Serialization.XmlElementAttribute("position", typeof(GeometryPropertyType1))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    public MeasureType1 speed {
        get {
            return this.speedField;
        }
        set {
            this.speedField = value;
        }
    }
    
    /// <remarks/>
    public DirectionPropertyType1 bearing {
        get {
            return this.bearingField;
        }
        set {
            this.bearingField = value;
        }
    }
    
    /// <remarks/>
    public MeasureType1 acceleration {
        get {
            return this.accelerationField;
        }
        set {
            this.accelerationField = value;
        }
    }
    
    /// <remarks/>
    public MeasureType1 elevation {
        get {
            return this.elevationField;
        }
        set {
            this.elevationField = value;
        }
    }
    
    /// <remarks/>
    public StringOrRefType1 status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    public ReferenceType1 statusReference {
        get {
            return this.statusReferenceField;
        }
        set {
            this.statusReferenceField = value;
        }
    }
}
}