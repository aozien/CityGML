
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodesicStringType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodesicType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ClothoidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OffsetCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BSplineType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BezierType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CubicSplineType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcByCenterPointType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleByCenterPointType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcStringByBulgeType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcByBulgeType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcStringType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringSegmentType1))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="AbstractCurveSegmentType", Namespace="http://www.opengis.net/gml")]
public abstract partial class AbstractCurveSegmentType1 {
    
    private string numDerivativesAtStartField;
    
    private string numDerivativesAtEndField;
    
    private string numDerivativeInteriorField;
    
    public AbstractCurveSegmentType1() {
        this.numDerivativesAtStartField = "0";
        this.numDerivativesAtEndField = "0";
        this.numDerivativeInteriorField = "0";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    [System.ComponentModel.DefaultValueAttribute("0")]
    public string numDerivativesAtStart {
        get {
            return this.numDerivativesAtStartField;
        }
        set {
            this.numDerivativesAtStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    [System.ComponentModel.DefaultValueAttribute("0")]
    public string numDerivativesAtEnd {
        get {
            return this.numDerivativesAtEndField;
        }
        set {
            this.numDerivativesAtEndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    [System.ComponentModel.DefaultValueAttribute("0")]
    public string numDerivativeInterior {
        get {
            return this.numDerivativeInteriorField;
        }
        set {
            this.numDerivativeInteriorField = value;
        }
    }
}
}