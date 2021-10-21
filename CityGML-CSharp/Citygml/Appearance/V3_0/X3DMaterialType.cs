
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
namespace CityGMLSharp.Citygml.Appearance.V3_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/appearance/3.0")]
[System.Xml.Serialization.XmlRootAttribute("X3DMaterial", Namespace="http://www.opengis.net/citygml/appearance/3.0", IsNullable=false)]
public partial class X3DMaterialType : AbstractSurfaceDataType {
    
    private double ambientIntensityField;
    
    private string diffuseColorField;
    
    private string emissiveColorField;
    
    private string specularColorField;
    
    private double shininessField;
    
    private double transparencyField;
    
    private bool isSmoothField;
    
    private string[] targetField;
    
    public X3DMaterialType() {
        this.ambientIntensityField = 0.2D;
        this.diffuseColorField = "0.8 0.8 0.8";
        this.emissiveColorField = "0.0 0.0 0.0";
        this.specularColorField = "1.0 1.0 1.0";
        this.shininessField = 0.2D;
        this.transparencyField = 0D;
        this.isSmoothField = false;
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(0.2D)]
    public double ambientIntensity {
        get {
            return this.ambientIntensityField;
        }
        set {
            this.ambientIntensityField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute("0.8 0.8 0.8")]
    public string diffuseColor {
        get {
            return this.diffuseColorField;
        }
        set {
            this.diffuseColorField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute("0.0 0.0 0.0")]
    public string emissiveColor {
        get {
            return this.emissiveColorField;
        }
        set {
            this.emissiveColorField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute("1.0 1.0 1.0")]
    public string specularColor {
        get {
            return this.specularColorField;
        }
        set {
            this.specularColorField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(0.2D)]
    public double shininess {
        get {
            return this.shininessField;
        }
        set {
            this.shininessField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(0D)]
    public double transparency {
        get {
            return this.transparencyField;
        }
        set {
            this.transparencyField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isSmooth {
        get {
            return this.isSmoothField;
        }
        set {
            this.isSmoothField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("target", DataType="anyURI")]
    public string[] target {
        get {
            return this.targetField;
        }
        set {
            this.targetField = value;
        }
    }
}
}