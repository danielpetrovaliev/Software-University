<?php
/**
 * Created by PhpStorm.
 * User: petrovaliev95
 * Date: 18-Oct-14
 * Time: 18:04
 */
namespace Rooms;

use Utility\RoomInformation;
use Utility\RoomType;

class Apartment extends Room {
    public function __construct($roomNumber, $price)
    {
        parent::__construct(new RoomInformation(4, $price, true, true,
                "TV, air-conditioner, refrigerator, kitchen box, mini-bar, bathtub, free Wi-fi", $roomNumber, RoomType::Diamond));
    }

    function __toString()
    {
        return parent::__toString();

    }
} 