
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="SphereType", Namespace="http://www.opengis.net/gml")]
[System.Xml.Serialization.XmlRootAttribute("Sphere", Namespace="http://www.opengis.net/gml", IsNullable=false)]
public partial class SphereType1 : AbstractGriddedSurfaceType2 {
    
    private CurveInterpolationType1 horizontalCurveTypeField;
    
    private bool horizontalCurveTypeFieldSpecified;
    
    private CurveInterpolationType1 verticalCurveTypeField;
    
    private bool verticalCurveTypeFieldSpecified;
    
    public SphereType1() {
        this.horizontalCurveTypeField = CurveInterpolationType1.circularArc3Points;
        this.verticalCurveTypeField = CurveInterpolationType1.circularArc3Points;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CurveInterpolationType1 horizontalCurveType {
        get {
            return this.horizontalCurveTypeField;
        }
        set {
            this.horizontalCurveTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool horizontalCurveTypeSpecified {
        get {
            return this.horizontalCurveTypeFieldSpecified;
        }
        set {
            this.horizontalCurveTypeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CurveInterpolationType1 verticalCurveType {
        get {
            return this.verticalCurveTypeField;
        }
        set {
            this.verticalCurveTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool verticalCurveTypeSpecified {
        get {
            return this.verticalCurveTypeFieldSpecified;
        }
        set {
            this.verticalCurveTypeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="CurveInterpolationType", Namespace="http://www.opengis.net/gml")]
public enum CurveInterpolationType1 {
    
    /// <remarks/>
    linear,
    
    /// <remarks/>
    geodesic,
    
    /// <remarks/>
    circularArc3Points,
    
    /// <remarks/>
    circularArc2PointWithBulge,
    
    /// <remarks/>
    circularArcCenterPointWithRadius,
    
    /// <remarks/>
    elliptical,
    
    /// <remarks/>
    clothoid,
    
    /// <remarks/>
    conic,
    
    /// <remarks/>
    polynomialSpline,
    
    /// <remarks/>
    cubicSpline,
    
    /// <remarks/>
    rationalSpline,
}
}