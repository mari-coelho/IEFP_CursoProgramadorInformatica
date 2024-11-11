/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Classes;

/**
 *
 * @author maria
 */
public class Pessoa {
    protected String Nome;
    protected String Morada;


    public Pessoa() {
        Nome = "";
        Morada = "";
    }
    
    public String getNome() {
        return Nome;
    }
    
    public void setNome(String n) {
        Nome = n;
    }
       
    public String getMorada() {
        return Morada;
    }

    public void setMorada(String m) {
        Morada = m;
    }
}
