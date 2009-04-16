/*
using MyGeneration/Template/NHibernate (c) by Sharp 1.4
based on OHM (alvy77@hotmail.com)
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace EZTutor.Data.Remote.Entities
{
    /// <summary>
    /// ITopics interface for NHibernate mapped table 'Topics'.
    /// </summary>
    public interface ITopics
    {
        #region Public Properties
		
        Guid Topicid
        {
            get ;
            set ;
			  
        }
		
        string TopicName
        {
            get ;
            set ;
			  
        }
		
        SlidesCollection ColFkSlidesTopics
        {
            get ;
            set ;
        }
		
		
        IList<Slides> FkSlidesTopics
        {
            get ;
            set ;
			  
        }
		
        bool IsDeleted { get; set; }
        bool IsChanged { get; set; }
		
        #endregion 
    }

    /// <summary>
    /// Topics object for NHibernate mapped table 'Topics'.
    /// </summary>
    [Serializable]
    public class Topics : ICloneable,ITopics
    {
        #region Member Variables

        protected Guid _topicid;
        protected string _topicname;
        protected IList<Slides> _fkslidestopics;
        protected bool _bIsDeleted;
        protected bool _bIsChanged;
        #endregion
		
        #region Constructors
        public Topics() {}
		
        public Topics(Guid pTopicid, string pTopicName)
        {
            this._topicid = pTopicid; 
            this._topicname = pTopicName; 
        }
		
        public Topics(Guid pTopicid)
        {
            this._topicid = pTopicid; 
        }
		
        #endregion
		
        #region Public Properties
		
        public virtual Guid Topicid
        {
            get { return _topicid; }
            set { _bIsChanged |= (_topicid != value); _topicid = value; }
			
        }
		
        public virtual string TopicName
        {
            get { return _topicname; }
            set { _bIsChanged |= (_topicname != value); _topicname = value; }
			
        }
		
        public virtual SlidesCollection ColFkSlidesTopics
        {
            get { SlidesCollection col = new SlidesCollection( _fkslidestopics ); _fkslidestopics = col.GetList(); return col; }
            set { _bIsChanged |= (_fkslidestopics != value); _fkslidestopics = value.GetList(); }
        }
		
        [System.Xml.Serialization.XmlIgnore]
        public virtual IList<Slides> FkSlidesTopics
        {
            get { return _fkslidestopics; }
            set { _bIsChanged |= (_fkslidestopics != value); _fkslidestopics = value; }
			
        }
		

        public virtual bool IsDeleted
        {
            get
            {
                return _bIsDeleted;
            }
            set
            {
                _bIsDeleted = value;
            }
        }
		
        public virtual bool IsChanged
        {
            get
            {
                return _bIsChanged;
            }
            set
            {
                _bIsChanged = value;
            }
        }
		
        #endregion 
		
        #region Equals And HashCode Overrides
        /// <summary>
        /// local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals( object obj )
        {
            if( this == obj ) return true;
            Topics castObj = null;
            try
            {
                castObj = (Topics)obj;
            } catch(Exception) { return false; } 
            return ( castObj != null ) &&
                   ( this._topicid == castObj.Topicid );
        }
        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {
		  
			
            int hash = 57; 
            hash = 27 * hash * _topicid.GetHashCode();
            return hash; 
        }
        #endregion
		
        #region ICloneable methods
		
        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
		
        #endregion
    }

    public interface ITopicsCollection : ICollection
    {
        Topics this[int index]{	get; set; }
        void Add(Topics pTopics);
        void Clear();
    }

    [Serializable]
    public class TopicsCollection : ITopicsCollection
    {
        private IList<Topics> _arrayInternal;

        public TopicsCollection()
        {
            _arrayInternal = new List<Topics>();
        }
		
        public TopicsCollection( IList<Topics> pSource )
        {
            _arrayInternal = pSource;
            if(_arrayInternal == null)
            {
                _arrayInternal = new List<Topics>();
            }
        }

        public Topics this[int index]
        {
            get
            {
                return _arrayInternal[index];
            }
            set
            {
                _arrayInternal[index] = value;
            }
        }

        public int Count { get { return _arrayInternal.Count; } }
        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { return _arrayInternal; } }
        public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Topics[])array, index); }
        public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
        public void Add(Topics pTopics) { _arrayInternal.Add(pTopics); }
        public void Clear() { _arrayInternal.Clear(); }
        public IList<Topics> GetList() { return _arrayInternal; }
    }
}