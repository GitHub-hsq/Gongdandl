/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "泵房管理",TableName = "Jczl_Bfgl")]
    public partial class Jczl_Bfgl:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int id { get; set; }

       /// <summary>
       ///小区
       /// </summary>
       [Display(Name ="小区")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Xiaoqu { get; set; }

       /// <summary>
       ///小区地址
       /// </summary>
       [Display(Name ="小区地址")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Xiaoqudz { get; set; }

       /// <summary>
       ///物业名称
       /// </summary>
       [Display(Name ="物业名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Wyname { get; set; }

       /// <summary>
       ///所属分公司
       /// </summary>
       [Display(Name ="所属分公司")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Shufgs { get; set; }

       /// <summary>
       ///所属管线所
       /// </summary>
       [Display(Name ="所属管线所")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Shugxs { get; set; }

       /// <summary>
       ///创建人员
       /// </summary>
       [Display(Name ="创建人员")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Chuangjr { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime Chuangtime { get; set; }

       
    }
}