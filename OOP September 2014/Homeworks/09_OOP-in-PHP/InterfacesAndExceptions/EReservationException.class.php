<?php
/**
 * Created by PhpStorm.
 * User: petrovaliev95
 * Date: 17-Oct-14
 * Time: 23:05
 */
namespace InterfacesAndExceptions;
use Exception;

class EReservationException extends Exception {
    public function __construct($message = "Reservation already exist") {
        parent::__construct($message);
    }
}