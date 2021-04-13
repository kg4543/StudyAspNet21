using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DbHandlingWebApp.Models
{
    public class MaximRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

        //입력
        public Maxims AddMaxims(Maxims maxim)
        {
            string query = @"INSERT INTO Maxims (Name,Contnts) Values (@Name,@Contents);
                             Select Case(Scope_Identity() as int)";

            var id = db.Query<int>(query, maxim).Single();
            maxim.Id = id;
            return maxim;
        }

        //조회

        //수정
        
        //삭제
    }
}