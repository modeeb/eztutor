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
    /// ILectures interface for NHibernate mapped table 'Lectures'.
    /// </summary>
    public interface ILectures
    {
        #region Public Properties
		
        Guid Lectureid
        {
            get ;
            set ;
			  
        }
		
        string LectureName
        {
            get ;
            set ;
			  
        }
		
        int LectureWeek
        {
            get ;
            set ;
			  
        }
		
        SlidesCollection ColFkSlidesLectures
        {
            get ;
            set ;
        }
		
		
        IList<Slides> FkSlidesLectures
        {
            get ;
            set ;
			  
        }
		
        bool IsDeleted { get; set; }
        bool IsChanged { get; set; }
		
        #endregion 
    }

    /// <summary>
    /// Lectures object for NHibernate mapped table 'Lectures'.
    /// </summary>
    [Serializable]
    public class Lectures : ICloneable,ILectures
    {
        #region Member Variables

        protected Guid _lectureid;
        protected string _lecturename;
        protected int _lectureweek;
        protected IList<Slides> _fkslideslectures;
        protected bool _bIsDeleted;
        protected bool _bIsChanged;
        #endregion
		
        #region Constructors
        public Lectures() {}
		
        public Lectures(Guid pLectureid, string pLectureName, int pLectureWeek)
        {
            this._lectureid = pLectureid; 
            this._lecturename = pLectureName; 
            this._lectureweek = pLectureWeek; 
        }
		
        public Lectures(Guid pLectureid)
        {
            this._lectureid = pLectureid; 
        }
		
        #endregion
		
        #region Public Properties
		
        public virtual Guid Lectureid
        {
            get { return _lectureid; }
            set { _bIsChanged |= (_lectureid != value); _lectureid = value; }
			
        }
		
        public virtual string LectureName
        {
            get { return _lecturename; }
            set { _bIsChanged |= (_lecturename != value); _lecturename = value; }
			
        }
		
        public virtual int LectureWeek
        {
            get { return _lectureweek; }
            set { _bIsChanged |= (_lectureweek != value); _lectureweek = value; }
			
        }
		
        public virtual SlidesCollection ColFkSlidesLectures
        {
            get { SlidesCollection col = new SlidesCollection( _fkslideslectures ); _fkslideslectures = col.GetList(); return col; }
            set { _bIsChanged |= (_fkslideslectures != value); _fkslideslectures = value.GetList(); }
        }
		
        [System.Xml.Serialization.XmlIgnore]
        public virtual IList<Slides> FkSlidesLectures
        {
            get { return _fkslideslectures; }
            set { _bIsChanged |= (_fkslideslectures != value); _fkslideslectures = value; }
			
        }
		

        public bool IsDeleted
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
		
        public bool IsChanged
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
            Lectures castObj = null;
            try
            {
                castObj = (Lectures)obj;
            } catch(Exception) { return false; } 
            return ( castObj != null ) &&
                   ( this._lectureid == castObj.Lectureid );
        }
        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {
		  
			
            int hash = 57; 
            hash = 27 * hash * _lectureid.GetHashCode();
            return hash; 
        }
        #endregion
		
        #region ICloneable methods
		
        public object Clone()
        {
            return this.MemberwiseClone();
        }
		
        #endregion
    }

    public interface ILecturesCollection : ICollection
    {
        Lectures this[int index]{	get; set; }
        void Add(Lectures pLectures);
        void Clear();
    }

    [Serializable]
    public class LecturesCollection : ILecturesCollection
    {
        private IList<Lectures> _arrayInternal;

        public LecturesCollection()
        {
            _arrayInternal = new List<Lectures>();
        }
		
        public LecturesCollection( IList<Lectures> pSource )
        {
            _arrayInternal = pSource;
            if(_arrayInternal == null)
            {
                _arrayInternal = new List<Lectures>();
            }
        }

        public Lectures this[int index]
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
        public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Lectures[])array, index); }
        public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
        public void Add(Lectures pLectures) { _arrayInternal.Add(pLectures); }
        public void Clear() { _arrayInternal.Clear(); }
        public IList<Lectures> GetList() { return _arrayInternal; }
    }
}