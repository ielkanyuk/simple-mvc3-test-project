﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DocumentsDataModel", "FK_Document_DocTypeTable", "DocTypeTable", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(UnicloudTestProject.Models.DocTypeTable), "Document", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(UnicloudTestProject.Models.Document), true)]
[assembly: EdmRelationshipAttribute("DocumentsDataModel", "FK_Document_Person", "Person", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(UnicloudTestProject.Models.Person), "Document", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(UnicloudTestProject.Models.Document), true)]

#endregion

namespace UnicloudTestProject.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class UniclTestDataEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new UniclTestDataEntities object using the connection string found in the 'UniclTestDataEntities' section of the application configuration file.
        /// </summary>
        public UniclTestDataEntities() : base("name=UniclTestDataEntities", "UniclTestDataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new UniclTestDataEntities object.
        /// </summary>
        public UniclTestDataEntities(string connectionString) : base(connectionString, "UniclTestDataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new UniclTestDataEntities object.
        /// </summary>
        public UniclTestDataEntities(EntityConnection connection) : base(connection, "UniclTestDataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<DocTypeTable> DocTypeTable
        {
            get
            {
                if ((_DocTypeTable == null))
                {
                    _DocTypeTable = base.CreateObjectSet<DocTypeTable>("DocTypeTable");
                }
                return _DocTypeTable;
            }
        }
        private ObjectSet<DocTypeTable> _DocTypeTable;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Document> Document
        {
            get
            {
                if ((_Document == null))
                {
                    _Document = base.CreateObjectSet<Document>("Document");
                }
                return _Document;
            }
        }
        private ObjectSet<Document> _Document;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Person> Person
        {
            get
            {
                if ((_Person == null))
                {
                    _Person = base.CreateObjectSet<Person>("Person");
                }
                return _Person;
            }
        }
        private ObjectSet<Person> _Person;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the DocTypeTable EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDocTypeTable(DocTypeTable docTypeTable)
        {
            base.AddObject("DocTypeTable", docTypeTable);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Document EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDocument(Document document)
        {
            base.AddObject("Document", document);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Person EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPerson(Person person)
        {
            base.AddObject("Person", person);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DocumentsDataModel", Name="DocTypeTable")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class DocTypeTable : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new DocTypeTable object.
        /// </summary>
        /// <param name="docType">Initial value of the DocType property.</param>
        public static DocTypeTable CreateDocTypeTable(global::System.Int32 docType)
        {
            DocTypeTable docTypeTable = new DocTypeTable();
            docTypeTable.DocType = docType;
            return docTypeTable;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DocType
        {
            get
            {
                return _DocType;
            }
            set
            {
                if (_DocType != value)
                {
                    OnDocTypeChanging(value);
                    ReportPropertyChanging("DocType");
                    _DocType = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DocType");
                    OnDocTypeChanged();
                }
            }
        }
        private global::System.Int32 _DocType;
        partial void OnDocTypeChanging(global::System.Int32 value);
        partial void OnDocTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TypeName
        {
            get
            {
                return _TypeName;
            }
            set
            {
                OnTypeNameChanging(value);
                ReportPropertyChanging("TypeName");
                _TypeName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TypeName");
                OnTypeNameChanged();
            }
        }
        private global::System.String _TypeName;
        partial void OnTypeNameChanging(global::System.String value);
        partial void OnTypeNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DocumentsDataModel", "FK_Document_DocTypeTable", "Document")]
        public EntityCollection<Document> Document
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Document>("DocumentsDataModel.FK_Document_DocTypeTable", "Document");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Document>("DocumentsDataModel.FK_Document_DocTypeTable", "Document", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DocumentsDataModel", Name="Document")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Document : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Document object.
        /// </summary>
        /// <param name="documentId">Initial value of the DocumentId property.</param>
        public static Document CreateDocument(global::System.Guid documentId)
        {
            Document document = new Document();
            document.DocumentId = documentId;
            return document;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid DocumentId
        {
            get
            {
                return _DocumentId;
            }
            set
            {
                if (_DocumentId != value)
                {
                    OnDocumentIdChanging(value);
                    ReportPropertyChanging("DocumentId");
                    _DocumentId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DocumentId");
                    OnDocumentIdChanged();
                }
            }
        }
        private global::System.Guid _DocumentId;
        partial void OnDocumentIdChanging(global::System.Guid value);
        partial void OnDocumentIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> DocType
        {
            get
            {
                return _DocType;
            }
            set
            {
                OnDocTypeChanging(value);
                ReportPropertyChanging("DocType");
                _DocType = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DocType");
                OnDocTypeChanged();
            }
        }
        private Nullable<global::System.Int32> _DocType;
        partial void OnDocTypeChanging(Nullable<global::System.Int32> value);
        partial void OnDocTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Serial
        {
            get
            {
                return _Serial;
            }
            set
            {
                OnSerialChanging(value);
                ReportPropertyChanging("Serial");
                _Serial = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Serial");
                OnSerialChanged();
            }
        }
        private global::System.String _Serial;
        partial void OnSerialChanging(global::System.String value);
        partial void OnSerialChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Number
        {
            get
            {
                return _Number;
            }
            set
            {
                OnNumberChanging(value);
                ReportPropertyChanging("Number");
                _Number = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Number");
                OnNumberChanged();
            }
        }
        private global::System.String _Number;
        partial void OnNumberChanging(global::System.String value);
        partial void OnNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> IssueDate
        {
            get
            {
                return _IssueDate;
            }
            set
            {
                OnIssueDateChanging(value);
                ReportPropertyChanging("IssueDate");
                _IssueDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IssueDate");
                OnIssueDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _IssueDate;
        partial void OnIssueDateChanging(Nullable<global::System.DateTime> value);
        partial void OnIssueDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Guid> OwningPersonId
        {
            get
            {
                return _OwningPersonId;
            }
            set
            {
                OnOwningPersonIdChanging(value);
                ReportPropertyChanging("OwningPersonId");
                _OwningPersonId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OwningPersonId");
                OnOwningPersonIdChanged();
            }
        }
        private Nullable<global::System.Guid> _OwningPersonId;
        partial void OnOwningPersonIdChanging(Nullable<global::System.Guid> value);
        partial void OnOwningPersonIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DocumentsDataModel", "FK_Document_DocTypeTable", "DocTypeTable")]
        public DocTypeTable DocTypeTable
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<DocTypeTable>("DocumentsDataModel.FK_Document_DocTypeTable", "DocTypeTable").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<DocTypeTable>("DocumentsDataModel.FK_Document_DocTypeTable", "DocTypeTable").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<DocTypeTable> DocTypeTableReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<DocTypeTable>("DocumentsDataModel.FK_Document_DocTypeTable", "DocTypeTable");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<DocTypeTable>("DocumentsDataModel.FK_Document_DocTypeTable", "DocTypeTable", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DocumentsDataModel", "FK_Document_Person", "Person")]
        public Person Person
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("DocumentsDataModel.FK_Document_Person", "Person").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("DocumentsDataModel.FK_Document_Person", "Person").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Person> PersonReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("DocumentsDataModel.FK_Document_Person", "Person");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Person>("DocumentsDataModel.FK_Document_Person", "Person", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DocumentsDataModel", Name="Person")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Person : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="personId">Initial value of the PersonId property.</param>
        public static Person CreatePerson(global::System.Guid personId)
        {
            Person person = new Person();
            person.PersonId = personId;
            return person;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid PersonId
        {
            get
            {
                return _PersonId;
            }
            set
            {
                if (_PersonId != value)
                {
                    OnPersonIdChanging(value);
                    ReportPropertyChanging("PersonId");
                    _PersonId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PersonId");
                    OnPersonIdChanged();
                }
            }
        }
        private global::System.Guid _PersonId;
        partial void OnPersonIdChanging(global::System.Guid value);
        partial void OnPersonIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                OnMiddleNameChanging(value);
                ReportPropertyChanging("MiddleName");
                _MiddleName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MiddleName");
                OnMiddleNameChanged();
            }
        }
        private global::System.String _MiddleName;
        partial void OnMiddleNameChanging(global::System.String value);
        partial void OnMiddleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> BirthDate
        {
            get
            {
                return _BirthDate;
            }
            set
            {
                OnBirthDateChanging(value);
                ReportPropertyChanging("BirthDate");
                _BirthDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BirthDate");
                OnBirthDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _BirthDate;
        partial void OnBirthDateChanging(Nullable<global::System.DateTime> value);
        partial void OnBirthDateChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DocumentsDataModel", "FK_Document_Person", "Document")]
        public EntityCollection<Document> Document
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Document>("DocumentsDataModel.FK_Document_Person", "Document");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Document>("DocumentsDataModel.FK_Document_Person", "Document", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}