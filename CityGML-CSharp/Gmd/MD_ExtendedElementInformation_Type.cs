
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
namespace CityGMLSharp.Gmd
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
[System.Xml.Serialization.XmlRootAttribute("MD_ExtendedElementInformation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
public partial class MD_ExtendedElementInformation_Type : AbstractObject_Type {
    
    private CharacterString_PropertyType nameField;
    
    private CharacterString_PropertyType shortNameField;
    
    private Integer_PropertyType domainCodeField;
    
    private CharacterString_PropertyType definitionField;
    
    private MD_ObligationCode_PropertyType obligationField;
    
    private CharacterString_PropertyType conditionField;
    
    private MD_DatatypeCode_PropertyType dataTypeField;
    
    private CharacterString_PropertyType maximumOccurrenceField;
    
    private CharacterString_PropertyType domainValueField;
    
    private CharacterString_PropertyType[] parentEntityField;
    
    private CharacterString_PropertyType ruleField;
    
    private CharacterString_PropertyType[] rationaleField;
    
    private CI_ResponsibleParty_PropertyType[] sourceField;
    
    /// <remarks/>
    public CharacterString_PropertyType name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType shortName {
        get {
            return this.shortNameField;
        }
        set {
            this.shortNameField = value;
        }
    }
    
    /// <remarks/>
    public Integer_PropertyType domainCode {
        get {
            return this.domainCodeField;
        }
        set {
            this.domainCodeField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType definition {
        get {
            return this.definitionField;
        }
        set {
            this.definitionField = value;
        }
    }
    
    /// <remarks/>
    public MD_ObligationCode_PropertyType obligation {
        get {
            return this.obligationField;
        }
        set {
            this.obligationField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType condition {
        get {
            return this.conditionField;
        }
        set {
            this.conditionField = value;
        }
    }
    
    /// <remarks/>
    public MD_DatatypeCode_PropertyType dataType {
        get {
            return this.dataTypeField;
        }
        set {
            this.dataTypeField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType maximumOccurrence {
        get {
            return this.maximumOccurrenceField;
        }
        set {
            this.maximumOccurrenceField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType domainValue {
        get {
            return this.domainValueField;
        }
        set {
            this.domainValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parentEntity")]
    public CharacterString_PropertyType[] parentEntity {
        get {
            return this.parentEntityField;
        }
        set {
            this.parentEntityField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType rule {
        get {
            return this.ruleField;
        }
        set {
            this.ruleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("rationale")]
    public CharacterString_PropertyType[] rationale {
        get {
            return this.rationaleField;
        }
        set {
            this.rationaleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("source")]
    public CI_ResponsibleParty_PropertyType[] source {
        get {
            return this.sourceField;
        }
        set {
            this.sourceField = value;
        }
    }
}
}