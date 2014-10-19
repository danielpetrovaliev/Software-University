<?php
/**
 * Created by PhpStorm.
 * User: petrovaliev95
 * Date: 17-Oct-14
 * Time: 23:17
 */
namespace Rooms;

use Utility\RoomInformation;
use Utility\RoomType;


class SingleRoom extends Room{
    public function __construct($roomNumber, $price)
    {
        parent::__construct(new RoomInformation(1, $price, true, false,
                "TV, air-conditioner", $roomNumber, RoomType::Standard));
    }

    function __toString()
    {
        return parent::__toString();
    }


}