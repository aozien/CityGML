
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
namespace CityGMLSharp.Gml.V3_2
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleByCenterPointType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
[System.Xml.Serialization.XmlRootAttribute("ArcByCenterPoint", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
public partial class ArcByCenterPointType : AbstractCurveSegmentType {
    
    private object itemField;
    
    private ItemChoiceType itemElementNameField;
    
    private LengthType radiusField;
    
    private AngleType startAngleField;
    
    private AngleType endAngleField;
    
    private CurveInterpolationType interpolationField;
    
    private bool interpolationFieldSpecified;
    
    private string numArcField;
    
    public ArcByCenterPointType() {
        this.interpolationField = CurveInterpolationType.circularArcCenterPointWithRadius;
        this.numArcField = "1";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
    [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    
    /// <remarks/>
    public LengthType radius {
        get {
            return this.radiusField;
        }
        set {
            this.radiusField = value;
        }
    }
    
    /// <remarks/>
    public AngleType startAngle {
        get {
            return this.startAngleField;
        }
        set {
            this.startAngleField = value;
        }
    }
    
    /// <remarks/>
    public AngleType endAngle {
        get {
            return this.endAngleField;
        }
        set {
            this.endAngleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CurveInterpolationType interpolation {
        get {
            return this.interpolationField;
        }
        set {
            this.interpolationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool interpolationSpecified {
        get {
            return this.interpolationFieldSpecified;
        }
        set {
            this.interpolationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string numArc {
        get {
            return this.numArcField;
        }
        set {
            this.numArcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    coordinates,
    
    /// <remarks/>
    pointProperty,
    
    /// <remarks/>
    pointRep,
    
    /// <remarks/>
    pos,
    
    /// <remarks/>
    posList,
}
}