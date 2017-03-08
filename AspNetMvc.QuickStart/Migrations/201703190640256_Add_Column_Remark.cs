namespace AspNetMvc.QuickStart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_Remark : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Remark", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Remark");
        }
    }
}
