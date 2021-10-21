
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
namespace CityGMLSharp.Urn_oasis_names_tc_ciq_xsdschema_xAL_2_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:ciq:xsdschema:xAL:2.0")]
public partial class AddressDetailsPostalServiceElements {
    
    private AddressDetailsPostalServiceElementsAddressIdentifier[] addressIdentifierField;
    
    private AddressDetailsPostalServiceElementsEndorsementLineCode endorsementLineCodeField;
    
    private AddressDetailsPostalServiceElementsKeyLineCode keyLineCodeField;
    
    private AddressDetailsPostalServiceElementsBarcode barcodeField;
    
    private AddressDetailsPostalServiceElementsSortingCode sortingCodeField;
    
    private AddressDetailsPostalServiceElementsAddressLatitude addressLatitudeField;
    
    private AddressDetailsPostalServiceElementsAddressLatitudeDirection addressLatitudeDirectionField;
    
    private AddressDetailsPostalServiceElementsAddressLongitude addressLongitudeField;
    
    private AddressDetailsPostalServiceElementsAddressLongitudeDirection addressLongitudeDirectionField;
    
    private AddressDetailsPostalServiceElementsSupplementaryPostalServiceData[] supplementaryPostalServiceDataField;
    
    private System.Xml.XmlElement[] anyField;
    
    private string typeField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AddressIdentifier")]
    public AddressDetailsPostalServiceElementsAddressIdentifier[] AddressIdentifier {
        get {
            return this.addressIdentifierField;
        }
        set {
            this.addressIdentifierField = value;
        }
    }
    
    /// <remarks/>
    public AddressDetailsPostalServiceElementsEndorsementLineCode EndorsementLineCode {
        get {
            return this.endorsementLineCodeField;
        }
        set {
            this.endorsementLineCodeField = value;
        }
    }
    
    /// <remarks/>
    public AddressDetailsPostalServiceElementsKeyLineCode KeyLineCode {
        get {
            return this.keyLineCodeField;
        }
        set {
            this.keyLineCodeField = value;
        }
    }
    
    /// <remarks/>
    public AddressDetailsPostalServiceElementsBarcode Barcode {
        get {
            return this.barcodeField;
        }
        set {
            this.barcodeField = value;
        }
    }
    
    /// <remarks/>
    public AddressDetailsPostalServiceElementsSortingCode SortingCode {
        get {
            return this.sortingCodeField;
        }
        set {
            this.sortingCodeField = value;
        }
    }
    
    /// <remarks/>
    public AddressDetailsPostalServiceElementsAddressLatitude AddressLatitude {
        get {
            return this.addressLatitudeField;
        }
        set {
            this.addressLatitudeField = value;
        }
    }
    
    /// <remarks/>
    public AddressDetailsPostalServiceElementsAddressLatitudeDirection AddressLatitudeDirection {
        get {
            return this.addressLatitudeDirectionField;
        }
        set {
            this.addressLatitudeDirectionField = value;
        }
    }
    
    /// <remarks/>
    public AddressDetailsPostalServiceElementsAddressLongitude AddressLongitude {
        get {
            return this.addressLongitudeField;
        }
        set {
            this.addressLongitudeField = value;
        }
    }
    
    /// <remarks/>
    public AddressDetailsPostalServiceElementsAddressLongitudeDirection AddressLongitudeDirection {
        get {
            return this.addressLongitudeDirectionField;
        }
        set {
            this.addressLongitudeDirectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SupplementaryPostalServiceData")]
    public AddressDetailsPostalServiceElementsSupplementaryPostalServiceData[] SupplementaryPostalServiceData {
        get {
            return this.supplementaryPostalServiceDataField;
        }
        set {
            this.supplementaryPostalServiceDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}
}