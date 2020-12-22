using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ONEUL
{
    class DBHelper
    {
        //일과 테이블 요소
        public static string tableName = "Oneul";
        public static string columnNo = "oneulNo";
        public static string columnTitle = "oneulTitle";
        public static string columnMemo = "oneulMemo";
        public static string columnStart = "oneulStart";
        public static string columnEnd = "oneulEnd";

        //일과 테이블 생성
        public static string createTable = "CREATE TABLE " + tableName + " (" +
                columnNo + " INT NOT NULL," +
                columnTitle + "CHAR(20) NOT NULL," +
                columnMemo + "CHAR(40)," +
                columnStart + "CHAR(10)," +
                columnEnd + "CHAR(10)," +
                "PRIMARY KEY ('" + columnNo + "')";
    }

    //using (MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306;Database= ONEUL; Uid=root; Pwd=root1111")) {


    

}
