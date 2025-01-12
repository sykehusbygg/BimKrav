﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BimKrav.Server.Tables;

[Table("property_project_junction")]
[Keyless]
public class ProjectPropertyTbl
{
    [Column("ID_Property", TypeName = "int(11)")]
    [DefaultValue("'NULL'")]
    public int? PropertyId { get; set; }

    [Column("ID_Project", TypeName = "int(11)")]
    [DefaultValue("'NULL'")]
    public int? ProjectId { get; set; }

    public virtual ProjectTbl? Project { get; set; }
    public virtual PropertyTbl? Property { get; set; }
}