package com.config;

import org.springframework.web.servlet.support.AbstractAnnotationConfigDispatcherServletInitializer;

public class AppInitializer extends AbstractAnnotationConfigDispatcherServletInitializer {
    protected Class<?>[] getRootConfigClasses() {
        return new Class[0];
    }

    protected Class<?>[] getServletConfigClasses() {
        return new Class[] {com.config.AppConfig.class, AppSecurityConfig.class};
    }

    protected String[] getServletMappings() {
        return new String[] {"/"};
    }
}
