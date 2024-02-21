package it.leddaz;

public class Item {

    public int id;
    public String name;
    public String desc;
    public double price;
    public int stock;
    public int vat;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDesc() {
        return desc;
    }

    public void setDesc(String desc) {
        this.desc = desc;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public int getStock() {
        return stock;
    }

    public void setStock(int stock) {
        this.stock = stock;
    }

    public int getVat() {
        return vat;
    }

    public void setVat(int vat) {
        this.vat = vat;
    }

    @Override
    public String toString() {
        return "ID: " + getId() + "\nName: " + getName() + "\nDesc: " + getDesc() + "\nPrice: "
                + getPrice() + "\nStock: " + getStock() + "\nVAT: " + getVat();
    }

}
