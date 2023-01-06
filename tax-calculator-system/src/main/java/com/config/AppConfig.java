package com.config;

import com.mysql.cj.jdbc.MysqlDataSource;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.EnableAspectJAutoProxy;
import org.springframework.orm.hibernate5.HibernateTransactionManager;
import org.springframework.orm.hibernate5.LocalSessionFactoryBean;
import org.springframework.transaction.PlatformTransactionManager;
import org.springframework.transaction.annotation.EnableTransactionManagement;
import org.springframework.web.servlet.ViewResolver;
import org.springframework.web.servlet.config.annotation.EnableWebMvc;
import org.springframework.web.servlet.config.annotation.ResourceHandlerRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;
import org.springframework.web.servlet.view.InternalResourceViewResolver;

import javax.sql.DataSource;
import java.util.Properties;

@Configuration
@EnableWebMvc
@EnableTransactionManagement
@EnableAspectJAutoProxy
@ComponentScan(basePackages = {"com.constant","com.repository", "com.service", "com.controller", "com.domain", "com.exception", "com.aop",})
public class AppConfig implements WebMvcConfigurer {

    @Override
    public void addResourceHandlers(ResourceHandlerRegistry registry) {
        registry.addResourceHandler("/css/**")
                .addResourceLocations("/css");
    }

    @Bean
    public ViewResolver viewResolver() {
        InternalResourceViewResolver internalResourceViewResolver = new InternalResourceViewResolver();
        internalResourceViewResolver.setPrefix("/WEB-INF/views/");
        internalResourceViewResolver.setSuffix(".jsp");
        return internalResourceViewResolver;
    }

    @Bean
    public DataSource dataSource() {
        MysqlDataSource mysqlDataSource = new MysqlDataSource();
        mysqlDataSource.setDatabaseName("finalassignment");
        mysqlDataSource.setURL("jdbc:mysql://localhost:3306/finalassignment");
        mysqlDataSource.setUser("root");
        mysqlDataSource.setPassword("root");
        return mysqlDataSource;
    }

    @Bean
    public LocalSessionFactoryBean sessionFactory() {
        LocalSessionFactoryBean sessionFactory = new LocalSessionFactoryBean();
        sessionFactory.setDataSource(dataSource());
        sessionFactory.setPackagesToScan("com.domain");
        Properties properties = new Properties();
        sessionFactory.setHibernateProperties(properties);
        return sessionFactory;
    }

    @Bean
    public PlatformTransactionManager transactionManager() {
        HibernateTransactionManager transactionManager = new HibernateTransactionManager();
        transactionManager.setSessionFactory(sessionFactory().getObject());
        return transactionManager;
    }
}
