import React from 'react'
import {Link} from 'react-router-dom'
import {
    Form,
    FormGroup,
    Label,
    Input,
    Button
} from 'reactstrap'

export const EditEmployer = () => {
    return (
        <Form>
            <FormGroup>
                <Label>Name</Label>
                <Input type="text" placeholder="Ivan"></Input>
                <Label>Surname</Label>
                <Input type="text" placeholder="Ivanov"></Input>
                <Label>Midname</Label>
                <Input type="text" placeholder="Ivanich"></Input>
                <Label>Position</Label>
                <Input type="text" placeholder="HR"></Input>
                <Label>Note</Label>
                <Input type="text" placeholder="About..."></Input>
                <Label>MaternityLeave</Label>
                <Input type="text" placeholder="True/False"></Input>
                <Label>BirthDate</Label>
                <Input type="text" placeholder="Enter"></Input>
            </FormGroup>
            <Button type="submit">Submit</Button>
            <Link to="/" className="btn btn-danger ml-2">Cancel</Link>
        </Form>
    )
}
