<?php
/**
 * Created by PhpStorm.
 * User: petrovaliev95
 * Date: 17-Oct-14
 * Time: 23:03
 */
namespace InterfacesAndExceptions;

interface iReservable {
    public function addReservation($reservation);
    public function removeReservation($reservation);
} 