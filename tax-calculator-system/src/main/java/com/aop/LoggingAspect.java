package com.aop;

import com.domain.Authority;
import org.apache.log4j.Logger;
import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.*;
import org.aspectj.lang.reflect.MethodSignature;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContext;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.User;
import org.springframework.stereotype.Component;

@Aspect
@Component
public class LoggingAspect {
    private static final Logger logger = Logger.getLogger(LoggingAspect.class);

    @Before("execution(public * getAll())")
    public void beforeAdvice() {
        Authentication authentication = SecurityContextHolder.getContext().getAuthentication();
        String username = "anonymous";
        if (authentication != null) {
            User user = (User) authentication.getPrincipal();
            username = user.getUsername();
        }
        logger.info(username + ": Executing @Before advice on createLeaveApplication() ");
    }

    @Before("execution(public * com.service.*.*(..))")
    public void all() {
        logger.info("Executing @Before advice on every method in service package()");
    }

    @Before("execution(public * com.service.*.*(..))")
    public void allWithJointPoint(JoinPoint joinPoint) {
        logger.info("Executing @Before advice on every method in service package()");
        MethodSignature methodSignature = (MethodSignature) joinPoint.getSignature();
        logger.error(methodSignature.toString());
        for(int i = 0; i < joinPoint.getArgs().length; i++) {
            logger.info(joinPoint.getArgs()[i].getClass().getSimpleName());
            logger.info(joinPoint.getArgs()[i].toString());
        }
    }
}