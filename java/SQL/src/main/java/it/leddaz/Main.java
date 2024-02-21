package it.leddaz;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.sql.*;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        try {
            System.out.println("Connecting...");
            DriverManager.registerDriver(new com.microsoft.sqlserver.jdbc.SQLServerDriver());
            Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost;databaseName=caramba;integratedSecurity=true;encrypt=true;trustServerCertificate=true;");
            System.out.println("The driver has been registered!");
            System.out.println("Ready");
            Statement myStatement = conn.createStatement();
            String query = "SELECT * FROM TabArticoli";
            ResultSet result = myStatement.executeQuery(query);
            ArrayList<Item> items = new ArrayList<>();
            while (result.next()) {
                Item i = new Item();
                i.setId(result.getInt("ID"));
                i.setName(result.getString("Nome"));
                i.setDesc(result.getString("Descrizione"));
                i.setPrice(result.getDouble("Prezzo"));
                i.setStock(result.getInt("Giacenza"));
                i.setVat(result.getInt("IVA"));
                items.add(i);
            }
            conn.close();
            Gson gson = new GsonBuilder().setPrettyPrinting().create();
            System.out.println((gson.toJson(items)));
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

}