package com.domain;

import com.constant.Gender;

import javax.persistence.*;
import javax.validation.constraints.NotNull;
import java.util.List;

@Entity
@Table(name = "user")
public class User {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @NotNull
    @Column(name = "name")
    private String name;
    @NotNull
    @Column(name = "username")
    private String username;
    @NotNull
    @Column(name="gender")
    private String gender;
    @NotNull
    @Column(name = "contact")
    private String contact;
    @NotNull
    @Column(name = "email")
    private String email;
    @NotNull
    @Column(name = "password")
    private String password;
    @NotNull
    @Column(name = "age")
    private int age;
    @NotNull
    @Column(name = "disabled")
    private boolean disabled;
    @NotNull
    @Column(name = "freedomfighter")
    private boolean freedomFighter;
    @NotNull
    @Column(name = "senior")
    private boolean senior;
    @ManyToMany(fetch = FetchType.EAGER)
    @JoinTable(name = "user_authority_map",
            joinColumns = @JoinColumn(name = "user_id"),
            inverseJoinColumns = @JoinColumn(name = "authority_id")
    )
    private List<Authority> authorities;
    public Long getId() {
        return id;
    }
    public void setId(Long id) {
        this.id = id;
    }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public String getUsername() {
        return username;
    }
    public void setUsername(String username) {
        this.username = username;
    }
    public String getPassword() {return password;}
    public void setPassword(String password) {
        this.password = password;
    }
    public String getGender() {return gender;}
    public void setGender(String gender) {this.gender = gender;}
    public String getEmail() {
        return email;
    }
    public void setEmail(String email) {
        this.email = email;
    }
    public String getContact() {
        return contact;
    }
    public void setContact(String contact) {
        this.contact = contact;
    }
    public int getAge() {return age;}
    public void setAge(int age) {this.age = age;}
    public boolean getDisabled() {
        return disabled;
    }
    public void setEnabled(boolean enabled) {
        disabled = enabled;
    }
    public boolean getFreedomFighter() {return freedomFighter;}
    public void setFreedomFighter(boolean enabled) {
        freedomFighter = enabled;
    }
    public boolean getSenior() {return senior;}
    public void setSenior(boolean enabled) {
        senior = enabled;
    }

    public List<Authority> getAuthorities() {
        return authorities;
    }
    public void setAuthorities(List<Authority> authorities) {
        this.authorities = authorities;
    }
}