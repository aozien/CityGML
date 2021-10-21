
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcByBulgeType1))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ArcStringByBulgeType", Namespace="http://www.opengis.net/gml")]
[System.Xml.Serialization.XmlRootAttribute("ArcStringByBulge", Namespace="http://www.opengis.net/gml", IsNullable=false)]
public partial class ArcStringByBulgeType1 : AbstractCurveSegmentType1 {
    
    private object[] itemsField;
    
    private ItemsChoiceType13[] itemsElementNameField;
    
    private double[] bulgeField;
    
    private VectorType2[] normalField;
    
    private CurveInterpolationType1 interpolationField;
    
    private bool interpolationFieldSpecified;
    
    private string numArcField;
    
    public ArcStringByBulgeType1() {
        this.interpolationField = CurveInterpolationType1.circularArc2PointWithBulge;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType1))]
    [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType1))]
    [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType1))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType1))]
    [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType1))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType13[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bulge")]
    public double[] bulge {
        get {
            return this.bulgeField;
        }
        set {
            this.bulgeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("normal")]
    public VectorType2[] normal {
        get {
            return this.normalField;
        }
        set {
            this.normalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CurveInterpolationType1 interpolation {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml", IncludeInSchema=false)]
public enum ItemsChoiceType13 {
    
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