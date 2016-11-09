//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieResources
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Movie()
        {
            this.tbl_Ask = new HashSet<tbl_Ask>();
            this.tbl_Comment = new HashSet<tbl_Comment>();
            this.tbl_Discovery = new HashSet<tbl_Discovery>();
            this.tbl_MarkMovie = new HashSet<tbl_MarkMovie>();
            this.tbl_Resource = new HashSet<tbl_Resource>();
            this.tbl_Work = new HashSet<tbl_Work>();
        }
    
        public string movie_Id { get; set; }
        public string movie_Title { get; set; }
        public string movie_TitleEn { get; set; }
        public string movie_Aka { get; set; }
        public string movie_Directors { get; set; }
        public string movie_Writers { get; set; }
        public string movie_Casts { get; set; }
        public string movie_DirectorsId { get; set; }
        public string movie_WritersId { get; set; }
        public string movie_CastsId { get; set; }
        public string movie_Year { get; set; }
        public string movie_Pubdates { get; set; }
        public string movie_Durations { get; set; }
        public string movie_Genres { get; set; }
        public string movie_Languages { get; set; }
        public string movie_Countries { get; set; }
        public string movie_Rating { get; set; }
        public string movie_RatingCount { get; set; }
        public string movie_DoubanID { get; set; }
        public string movie_IMDbID { get; set; }
        public string movie_Summary { get; set; }
        public string movie_Avatar { get; set; }
        public string movie_Create { get; set; }
        public Nullable<byte> movie_Status { get; set; }
        public string movie_Note { get; set; }
        public Nullable<System.DateTime> movie_Time { get; set; }
        public Nullable<System.DateTime> movie_AlterTime { get; set; }
        public Nullable<int> movie_VisitCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Ask> tbl_Ask { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Comment> tbl_Comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Discovery> tbl_Discovery { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MarkMovie> tbl_MarkMovie { get; set; }
        public virtual tbl_UserAccount tbl_UserAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Resource> tbl_Resource { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Work> tbl_Work { get; set; }
    }
}