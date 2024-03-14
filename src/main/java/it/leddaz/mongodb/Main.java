package it.leddaz.mongodb;

import com.mongodb.ConnectionString;
import com.mongodb.MongoClientSettings;
import com.mongodb.ServerApi;
import com.mongodb.ServerApiVersion;
import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoClients;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoDatabase;
import org.bson.Document;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

public class Main {
    public static void main(String[] args) {
        try {
            String connectionString = "";

            ServerApi serverApi = ServerApi.builder()
                    .version(ServerApiVersion.V1)
                    .build();

            // ...

            Logger logger = LoggerFactory.getLogger(Main.class);

            // ...

            items.find().forEach(doc -> logger.info(doc.toJson()));
            logger.info("ok");
        } catch(Exception e) {
            System.out.println("q");
        }
    }
}