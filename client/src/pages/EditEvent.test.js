import { render, screen } from '@testing-library/react';
import EditEvent from "./EditEvent";

test('renders Edit Event', () => {
    render(<EditEvent />);
    const linkElement = screen.getByText(/Edit Event/i);
    expect(linkElement).toBeInTheDocument();
});

test('renders Description', () => {
    render(<EditEvent />);
    const linkElement = screen.getByText(/Description/i);
    expect(linkElement).toBeInTheDocument();
});
