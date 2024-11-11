/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Classes;

import java.util.ArrayList;

/**
 *
 * @author maria
 */
public class Utente extends Pessoa {
    private int NISS;
    
    public static ArrayList<Utente> listaUtentes = new ArrayList<Utente>();
    
        
    public int getNiss() {
        return NISS;
    }

    public void setNiss(int n) {
        NISS = n;
    }
   
    public Utente ( String n,int niss, String m){
        Nome=n;
        NISS = niss;
        Morada=m;
    }
    
}
