package org.example;

import java.sql.*;
import java.util.Scanner;

/**
 * Sample SQL interactions
 *
 * @author Leonardo Ledda (LeddaZ)
 */
public class SusAmogus {

    private static final String connStr = "jdbc:sqlserver://localhost;databaseName=caramba;integratedSecurity=true;encrypt=true;trustServerCertificate=true;";

    public static void main(String[] args) {
        try {
            System.out.println("Connecting...");
            DriverManager.registerDriver(new com.microsoft.sqlserver.jdbc.SQLServerDriver());
            System.out.println("The driver has been registered!");
            //list();
            //insert();
            list();
            //delete();
            updateDesc();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    /**
     * Lists all products
     */
    public static void list() {
        try {
            Connection conn = DriverManager.getConnection(connStr);
            System.out.println("Ready");
            Statement myStatement = conn.createStatement();
            String query = "SELECT * FROM TabArticoli";
            ResultSet result = myStatement.executeQuery(query);
            ResultSetMetaData rsmd = result.getMetaData();
            while (result.next()) {
                System.out.println("----------");
                for (int i = 1; i <= 6; i++) {
                    System.out.print(rsmd.getColumnName(i) + ": ");
                    System.out.println(result.getString(i));
                }
            }
            conn.close();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    /**
     * Inserts a new product
     */
    public static void insert() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Name: ");
        String name = scanner.nextLine();
        System.out.print("Description: ");
        String desc = scanner.nextLine();
        System.out.print("Price: ");
        double price = scanner.nextDouble();
        System.out.print("Stock: ");
        int stock = scanner.nextInt();
        System.out.print("VAT: ");
        int vat = scanner.nextInt();
        try {
            Connection conn = DriverManager.getConnection(connStr);
            System.out.println("Ready");
            String query = "INSERT INTO TabArticoli (Nome, Descrizione, Prezzo, Giacenza, IVA) "
                    + "VALUES (?, ?, ?, ?, ?)";
            PreparedStatement prep = conn.prepareStatement(query);
            prep.setString(1, name);
            prep.setString(2, desc);
            prep.setDouble(3, price);
            prep.setInt(4, stock);
            prep.setInt(5, vat);
            prep.executeUpdate();
            conn.close();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    /**
     * Deletes a product
     */
    public static void delete() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Product ID: ");
        int id = scanner.nextInt();
        try {
            Connection conn = DriverManager.getConnection(connStr);
            System.out.println("Ready");
            String query = "DELETE FROM TabArticoli WHERE ID = ?";
            PreparedStatement prep = conn.prepareStatement(query);
            prep.setInt(1, id);
            prep.executeUpdate();
            System.out.println("Done");
            conn.close();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    /**
     * Updates product description
     */
    public static void updateDesc() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Product ID: ");
        int id = scanner.nextInt();
        scanner.nextLine();
        System.out.print("New description: ");
        String newDesc = scanner.nextLine();
        try {
            Connection conn = DriverManager.getConnection(connStr);
            System.out.println("Ready");
            String query = "UPDATE TabArticoli SET Descrizione = ? WHERE ID = ?";
            PreparedStatement prep = conn.prepareStatement(query);
            prep.setString(1, newDesc);
            prep.setInt(2, id);
            prep.executeUpdate();
            System.out.println("Done");
            conn.close();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }
}
