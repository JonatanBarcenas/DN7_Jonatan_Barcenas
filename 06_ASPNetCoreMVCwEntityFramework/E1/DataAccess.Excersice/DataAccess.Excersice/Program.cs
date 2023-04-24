﻿using DataAccess.Excersice.Entities;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace DataAccess.Excersice
{
	public class Program
	{

		const string mysqlConnectionString = "server=localhost;port=3306;database=gymmanager_db;user=root;password=@Canelo67";
		static void Main(string[] args)
		{

			var list = GetProductsByType(1);

			var listM = LastMembers();



		}

		private static List<LastMembersResult> LastMembers()
		{
			List<LastMembersResult> members = new List<LastMembersResult>();
			MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);
			connection.Open();
			try
			{
				MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("members_last_week", connection);
				command.CommandType = System.Data.CommandType.StoredProcedure;
				var reader = command.ExecuteReader();
				while (reader.Read())
				{
					LastMembersResult member = new LastMembersResult
					{
						MemberId= (int)reader["member_id"],
						InscriptionDate = reader["inscription_date"] as string,
						MembershipType = (int)reader["membership_type"]
						
					};
					members.Add(member);
				}
			}
			finally
			{
				connection.Close();
			}
			return members;
		}

		private static List<GetProductResult> GetProductsByType(int id)
		{
			List<GetProductResult> products = new List<GetProductResult>();
			MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);
			connection.Open();
			try
			{
				MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("get_products_by_type", connection);
				command.CommandType = System.Data.CommandType.StoredProcedure;
				command.Parameters.AddWithValue("product_type_id", id);
				var reader = command.ExecuteReader();
				while (reader.Read())
				{
					GetProductResult productResult = new GetProductResult
					{
						ProductId= (int)reader["productinventory_id"],
						ProductName= reader["name"] as string,
						Description= reader["description"] as string,
						Quantity = (int)reader["quantity"]
					};
					products.Add(productResult);
				}
			}
			finally 
			{ 
				connection.Close(); 
			}
			return products;

		}

		

		private static void CreateSell(int productId, int userId)
		{
			
			MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);
			connection.Open();
			try
			{
				MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("sp_registrar_venta", connection);
				command.CommandType = System.Data.CommandType.StoredProcedure;
				command.Parameters.AddWithValue("p_productinventory_id", productId);
				command.Parameters.AddWithValue("p_user_id", userId);
				command.ExecuteNonQuery();
			}
			finally
			{ 
				connection.Close();
			}
			
		}

		

	}
}
