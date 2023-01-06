package com.exception;

public class NotFoundAlertException extends RuntimeException {

    public NotFoundAlertException(String message) {
        super(message);
    }
}
