
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
namespace CityGMLSharp.Gmlcov.V1_0
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ParameterValueType", Namespace="http://www.opengis.net/gmlcov/1.0")]
[System.Xml.Serialization.XmlRootAttribute("ParameterValue", Namespace="http://www.opengis.net/gmlcov/1.0", IsNullable=false)]
public partial class ParameterValueType1 : AbstractGeneralParameterValueType1 {
    
    private object itemField;
    
    private ItemChoiceType7 itemElementNameField;
    
    private OperationParameterPropertyType1 operationParameterField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("booleanValue", typeof(bool), Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlElementAttribute("dmsAngleValue", typeof(DMSAngleType1), Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlElementAttribute("integerValue", typeof(string), Namespace="http://www.opengis.net/gml/3.2", DataType="positiveInteger")]
    [System.Xml.Serialization.XmlElementAttribute("integerValueList", typeof(string), Namespace="http://www.opengis.net/gml/3.2", DataType="integer")]
    [System.Xml.Serialization.XmlElementAttribute("stringValue", typeof(string), Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlElementAttribute("value", typeof(MeasureType), Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlElementAttribute("valueFile", typeof(string), Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
    [System.Xml.Serialization.XmlElementAttribute("valueList", typeof(MeasureListType1), Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlElementAttribute("geometryValue", typeof(GeometryPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("vectorValue", typeof(VectorType))]
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
    public ItemChoiceType7 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public OperationParameterPropertyType1 operationParameter {
        get {
            return this.operationParameterField;
        }
        set {
            this.operationParameterField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gmlcov/1.0", IncludeInSchema=false)]
public enum ItemChoiceType7 {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/gml/3.2:booleanValue")]
    booleanValue,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/gml/3.2:dmsAngleValue")]
    dmsAngleValue,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/gml/3.2:integerValue")]
    integerValue,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/gml/3.2:integerValueList")]
    integerValueList,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/gml/3.2:stringValue")]
    stringValue,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/gml/3.2:value")]
    value,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/gml/3.2:valueFile")]
    valueFile,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/gml/3.2:valueList")]
    valueList,
    
    /// <remarks/>
    geometryValue,
    
    /// <remarks/>
    vectorValue,
}
}