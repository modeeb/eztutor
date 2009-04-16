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
    /// ISlides interface for NHibernate mapped table 'Slides'.
    /// </summary>
    public interface ISlides
    {
        #region Public Properties
		
        Guid Slideid
        {
            get ;
            set ;
			  
        }
		
        string SlideName
        {
            get ;
            set ;
			  
        }
		
        Lectures Lectureid
        {
            get ;
            set ;
			  
        }
		
        Topics Topicid
        {
            get ;
            set ;
			  
        }
		
        bool IsDeleted { get; set; }
        bool IsChanged { get; set; }
		
        #endregion 
    }

    /// <summary>
    /// Slides object for NHibernate mapped table 'Slides'.
    /// </summary>
    [Serializable]
    public class Slides : ICloneable,ISlides
    {
        #region Member Variables

        protected Guid _slideid;
        protected string _slidename;
        protected Lectures _lectureid;
        protected Topics _topicid;
        protected bool _bIsDeleted;
        protected bool _bIsChanged;
        #endregion
		
        #region Constructors
        public Slides() {}
		
        public Slides(Guid pSlideid, string pSlideName, Lectures pLectureid, Topics pTopicid)
        {
            this._slideid = pSlideid; 
            this._slidename = pSlideName; 
            this._lectureid = pLectureid; 
            this._topicid = pTopicid; 
        }
		
        public Slides(Guid pSlideid)
        {
            this._slideid = pSlideid; 
        }
		
        #endregion
		
        #region Public Properties
		
        public virtual Guid Slideid
        {
            get { return _slideid; }
            set { _bIsChanged |= (_slideid != value); _slideid = value; }
			
        }
		
        public virtual string SlideName
        {
            get { return _slidename; }
            set { _bIsChanged |= (_slidename != value); _slidename = value; }
			
        }
		
        public virtual Lectures Lectureid
        {
            get { return _lectureid; }
            set { _bIsChanged |= (_lectureid != value); _lectureid = value; }
			
        }
		
        public virtual Topics Topicid
        {
            get { return _topicid; }
            set { _bIsChanged |= (_topicid != value); _topicid = value; }
			
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
            Slides castObj = null;
            try
            {
                castObj = (Slides)obj;
            } catch(Exception) { return false; } 
            return ( castObj != null ) &&
                   ( this._slideid == castObj.Slideid );
        }
        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {
		  
			
            int hash = 57; 
            hash = 27 * hash * _slideid.GetHashCode();
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

    public interface ISlidesCollection : ICollection
    {
        Slides this[int index]{	get; set; }
        void Add(Slides pSlides);
        void Clear();
    }

    [Serializable]
    public class SlidesCollection : ISlidesCollection
    {
        private IList<Slides> _arrayInternal;

        public SlidesCollection()
        {
            _arrayInternal = new List<Slides>();
        }
		
        public SlidesCollection( IList<Slides> pSource )
        {
            _arrayInternal = pSource;
            if(_arrayInternal == null)
            {
                _arrayInternal = new List<Slides>();
            }
        }

        public Slides this[int index]
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
        public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Slides[])array, index); }
        public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
        public void Add(Slides pSlides) { _arrayInternal.Add(pSlides); }
        public void Clear() { _arrayInternal.Clear(); }
        public IList<Slides> GetList() { return _arrayInternal; }
    }
}