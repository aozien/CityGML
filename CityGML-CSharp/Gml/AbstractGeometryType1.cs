
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GridType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometricComplexType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricAggregateType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiGeometryType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricPrimitiveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSolidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSolidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SolidType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableSurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyhedralSurfaceType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableCurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType1))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="AbstractGeometryType", Namespace="http://www.opengis.net/gml")]
public abstract partial class AbstractGeometryType1 : AbstractGMLType1 {
    
    private string srsNameField;
    
    private string srsDimensionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string srsName {
        get {
            return this.srsNameField;
        }
        set {
            this.srsNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
    public string srsDimension {
        get {
            return this.srsDimensionField;
        }
        set {
            this.srsDimensionField = value;
        }
    }
}
}