<?php
/**
 * Created by PhpStorm.
 * User: petrovaliev95
 * Date: 17-Oct-14
 * Time: 22:57
 */
namespace Utility;

class Reservation {
    private $startDate;
    private $endDate;
    private $guest;


    function __construct($startDate, $endDate, $guest)
    {
        $endDateInTime = $endDate;
        $startDateInTime = $startDate;
        $this->setEndDate($endDateInTime);
        $this->setGuest($guest);
        $this->setStartDate($startDateInTime);
    }


    /**
     * @return mixed
     */
    public function getEndDate()
    {
        return date("d-m-Y", $this->endDate);
    }

    /**
     * @param mixed $endDate
     */
    public function setEndDate($endDate)
    {
        $this->endDate = $endDate;
    }

    /**
     * @return mixed
     */
    public function getGuest()
    {
        return $this->guest;
    }

    /**
     * @param mixed $guest
     */
    public function setGuest($guest)
    {
        $this->guest = $guest;
    }

    /**
     * @return mixed
     */
    public function getStartDate()
    {
        return date("d-m-Y", $this->startDate);
    }

    /**
     * @param mixed $startDate
     */
    public function setStartDate($startDate)
    {
        $this->startDate = $startDate;
    }

    function __toString()
    {
        $result = "\tReservation( Start date: " . $this->getStartDate() .
            ", End date: " . $this->getEndDate() . ", Guest: {" . $this->getGuest() .
            "} )";
        return $result;
    }


} 