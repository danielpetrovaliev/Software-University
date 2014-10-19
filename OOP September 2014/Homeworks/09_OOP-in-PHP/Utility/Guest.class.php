<?php
/**
 * Created by PhpStorm.
 * User: petrovaliev95
 * Date: 18-Oct-14
 * Time: 11:19
 */
namespace Utility;

use InvalidArgumentException;

class Guest {
    private $firstName;
    private $lastName;
    private $id;

    function __construct($firstName, $lastName, $id)
    {
        $this->setFirstName($firstName);
        $this->setId($id);
        $this->setLastName($lastName);
    }


    /**
     * @return mixed
     */
    public function getFirstName()
    {
        return $this->firstName;
    }

    /**
     * @param mixed $firstName
     */
    public function setFirstName($firstName)
    {
        if ($firstName === null || $firstName === ""){
            throw new InvalidArgumentException("First name cannot be null or empty.");
        }
        $this->firstName = $firstName;
    }

    /**
     * @return mixed
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * @param mixed $id
     */
    public function setId($id)
    {
        if (!is_numeric($id)){
            throw new InvalidArgumentException("Id must be numeric.");
        }
        $this->id = $id;
    }

    /**
     * @return mixed
     */
    public function getLastName()
    {
        return $this->lastName;
    }

    /**
     * @param mixed $lastName
     */
    public function setLastName($lastName)
    {
        if ($lastName === null || $lastName === ""){
            throw new InvalidArgumentException("Last name cannot be null or empty.");
        }
        $this->lastName = $lastName;
    }

    function __toString()
    {
        $result = $this->getFirstName() . " " . $this->getLastName() . ", " . "EGN: " . $this->getId();
        return $result;
    }


} 