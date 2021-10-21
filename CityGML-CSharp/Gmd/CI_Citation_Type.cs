
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
[System.Xml.Serialization.XmlRootAttribute("CI_Citation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
public partial class CI_Citation_Type : AbstractObject_Type {
    
    private CharacterString_PropertyType titleField;
    
    private CharacterString_PropertyType[] alternateTitleField;
    
    private CI_Date_PropertyType[] dateField;
    
    private CharacterString_PropertyType editionField;
    
    private Date_PropertyType editionDateField;
    
    private MD_Identifier_PropertyType[] identifierField;
    
    private CI_ResponsibleParty_PropertyType[] citedResponsiblePartyField;
    
    private CI_PresentationFormCode_PropertyType[] presentationFormField;
    
    private CI_Series_PropertyType seriesField;
    
    private CharacterString_PropertyType otherCitationDetailsField;
    
    private CharacterString_PropertyType collectiveTitleField;
    
    private CharacterString_PropertyType iSBNField;
    
    private CharacterString_PropertyType iSSNField;
    
    /// <remarks/>
    public CharacterString_PropertyType title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("alternateTitle")]
    public CharacterString_PropertyType[] alternateTitle {
        get {
            return this.alternateTitleField;
        }
        set {
            this.alternateTitleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("date")]
    public CI_Date_PropertyType[] date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType edition {
        get {
            return this.editionField;
        }
        set {
            this.editionField = value;
        }
    }
    
    /// <remarks/>
    public Date_PropertyType editionDate {
        get {
            return this.editionDateField;
        }
        set {
            this.editionDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("identifier")]
    public MD_Identifier_PropertyType[] identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("citedResponsibleParty")]
    public CI_ResponsibleParty_PropertyType[] citedResponsibleParty {
        get {
            return this.citedResponsiblePartyField;
        }
        set {
            this.citedResponsiblePartyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("presentationForm")]
    public CI_PresentationFormCode_PropertyType[] presentationForm {
        get {
            return this.presentationFormField;
        }
        set {
            this.presentationFormField = value;
        }
    }
    
    /// <remarks/>
    public CI_Series_PropertyType series {
        get {
            return this.seriesField;
        }
        set {
            this.seriesField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType otherCitationDetails {
        get {
            return this.otherCitationDetailsField;
        }
        set {
            this.otherCitationDetailsField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType collectiveTitle {
        get {
            return this.collectiveTitleField;
        }
        set {
            this.collectiveTitleField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType ISBN {
        get {
            return this.iSBNField;
        }
        set {
            this.iSBNField = value;
        }
    }
    
    /// <remarks/>
    public CharacterString_PropertyType ISSN {
        get {
            return this.iSSNField;
        }
        set {
            this.iSSNField = value;
        }
    }
}
}