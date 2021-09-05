using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"USE [WebAppDatabase]
GO
/****** Object:  Trigger [dbo].[triggera]    Script Date: 8/10/2021 10:23:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[triggera]
on [dbo].[AspNetRoles]
after insert, update, delete
as
begin
update dbo.AspNetRoles
set Name = 'racxunia'
end
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        { 

        }
    }
}
