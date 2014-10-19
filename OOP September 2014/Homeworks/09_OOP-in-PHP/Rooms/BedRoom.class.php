<?php
/**
 * Created by PhpStorm.
 * User: petrovaliev95
 * Date: 18-Oct-14
 * Time: 17:55
 */
namespace Rooms;

use Utility\RoomInformation;
use Utility\RoomType;

class BedRoom extends Room{
    public function __construct($roomNumber, $price)
    {
        parent::__construct(new RoomInformation(2, $price, true, true,
                "TV, air-conditioner, refrigerator, mini-bar, bathtub", $roomNumber, RoomType::Gold));
    }

    function __toString()
    {
        return parent::__toString();
    }

}