
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
namespace CityGMLSharp.Citygml.Tunnel.V3_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/citygml/tunnel/3.0")]
[System.Xml.Serialization.XmlRootAttribute("Tunnel", Namespace="http://www.opengis.net/citygml/tunnel/3.0", IsNullable=false)]
public partial class TunnelType : AbstractTopLevelCityObjectType {
    
    private CodeType classField;
    
    private CodeType[] functionField;
    
    private CodeType[] usageField;
    
    private TunnelTypeInteriorHollowSpace[] interiorHollowSpaceField;
    
    private TunnelTypeTunnelInstallation[] tunnelInstallationField;
    
    private TunnelTypeTunnelFurniture[] tunnelFurnitureField;
    
    private TunnelTypeTunnelConstructiveElement[] tunnelConstructiveElementField;
    
    private ConstructionSpacePropertyType[] tunnelSpaceField;
    
    private ConditionOfConstructionValueType conditionOfConstructionField;
    
    private bool conditionOfConstructionFieldSpecified;
    
    private System.DateTime dateOfConstructionField;
    
    private bool dateOfConstructionFieldSpecified;
    
    private System.DateTime[] dateOfRenovationField;
    
    private System.DateTime dateOfDemolitionField;
    
    private bool dateOfDemolitionFieldSpecified;
    
    private ElevationPropertyType[] elevationField;
    
    private HeightAboveGroundPropertyType[] heightAboveGroundField;
    
    private TunnelTypeTunnelPart[] tunnelPartField;
    
    /// <remarks/>
    public CodeType @class {
        get {
            return this.classField;
        }
        set {
            this.classField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("function")]
    public CodeType[] function {
        get {
            return this.functionField;
        }
        set {
            this.functionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("usage")]
    public CodeType[] usage {
        get {
            return this.usageField;
        }
        set {
            this.usageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("interiorHollowSpace")]
    public TunnelTypeInteriorHollowSpace[] interiorHollowSpace {
        get {
            return this.interiorHollowSpaceField;
        }
        set {
            this.interiorHollowSpaceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tunnelInstallation")]
    public TunnelTypeTunnelInstallation[] tunnelInstallation {
        get {
            return this.tunnelInstallationField;
        }
        set {
            this.tunnelInstallationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tunnelFurniture")]
    public TunnelTypeTunnelFurniture[] tunnelFurniture {
        get {
            return this.tunnelFurnitureField;
        }
        set {
            this.tunnelFurnitureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tunnelConstructiveElement")]
    public TunnelTypeTunnelConstructiveElement[] tunnelConstructiveElement {
        get {
            return this.tunnelConstructiveElementField;
        }
        set {
            this.tunnelConstructiveElementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tunnelSpace")]
    public ConstructionSpacePropertyType[] tunnelSpace {
        get {
            return this.tunnelSpaceField;
        }
        set {
            this.tunnelSpaceField = value;
        }
    }
    
    /// <remarks/>
    public ConditionOfConstructionValueType conditionOfConstruction {
        get {
            return this.conditionOfConstructionField;
        }
        set {
            this.conditionOfConstructionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conditionOfConstructionSpecified {
        get {
            return this.conditionOfConstructionFieldSpecified;
        }
        set {
            this.conditionOfConstructionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dateOfConstruction {
        get {
            return this.dateOfConstructionField;
        }
        set {
            this.dateOfConstructionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dateOfConstructionSpecified {
        get {
            return this.dateOfConstructionFieldSpecified;
        }
        set {
            this.dateOfConstructionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dateOfRenovation", DataType="date")]
    public System.DateTime[] dateOfRenovation {
        get {
            return this.dateOfRenovationField;
        }
        set {
            this.dateOfRenovationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dateOfDemolition {
        get {
            return this.dateOfDemolitionField;
        }
        set {
            this.dateOfDemolitionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dateOfDemolitionSpecified {
        get {
            return this.dateOfDemolitionFieldSpecified;
        }
        set {
            this.dateOfDemolitionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("elevation")]
    public ElevationPropertyType[] elevation {
        get {
            return this.elevationField;
        }
        set {
            this.elevationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("heightAboveGround")]
    public HeightAboveGroundPropertyType[] heightAboveGround {
        get {
            return this.heightAboveGroundField;
        }
        set {
            this.heightAboveGroundField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tunnelPart")]
    public TunnelTypeTunnelPart[] tunnelPart {
        get {
            return this.tunnelPartField;
        }
        set {
            this.tunnelPartField = value;
        }
    }
}
}