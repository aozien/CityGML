
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
namespace CityGMLSharp.Gml.V3_2
{
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType1))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="AbstractCoordinateOperationType", Namespace="http://www.opengis.net/gml/3.2")]
public abstract partial class AbstractCoordinateOperationType1 : IdentifiedObjectType {
    
    private domainOfValidity domainOfValidityField;
    
    private string[] scopeField;
    
    private string operationVersionField;
    
    private coordinateOperationAccuracy1[] coordinateOperationAccuracyField;
    
    private CRSPropertyType1 sourceCRSField;
    
    private CRSPropertyType1 targetCRSField;
    
    /// <remarks/>
    public domainOfValidity domainOfValidity {
        get {
            return this.domainOfValidityField;
        }
        set {
            this.domainOfValidityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("scope")]
    public string[] scope {
        get {
            return this.scopeField;
        }
        set {
            this.scopeField = value;
        }
    }
    
    /// <remarks/>
    public string operationVersion {
        get {
            return this.operationVersionField;
        }
        set {
            this.operationVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("coordinateOperationAccuracy")]
    public coordinateOperationAccuracy1[] coordinateOperationAccuracy {
        get {
            return this.coordinateOperationAccuracyField;
        }
        set {
            this.coordinateOperationAccuracyField = value;
        }
    }
    
    /// <remarks/>
    public CRSPropertyType1 sourceCRS {
        get {
            return this.sourceCRSField;
        }
        set {
            this.sourceCRSField = value;
        }
    }
    
    /// <remarks/>
    public CRSPropertyType1 targetCRS {
        get {
            return this.targetCRSField;
        }
        set {
            this.targetCRSField = value;
        }
    }
}
}